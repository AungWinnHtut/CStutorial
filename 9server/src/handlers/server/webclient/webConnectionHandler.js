'use strict';

import mongoose from 'mongoose';
import { jwtVerify, SignJWT } from 'jose';
import { PrivateKey, PublicKey } from '../../internal/configHandler.js';
import { Device } from '../../internal/database/databaseHandler.js';
import {
  graphql,
  GraphQLSchema,
  GraphQLObjectType,
  GraphQLList,
  GraphQLBoolean,
  GraphQLString,
  GraphQLNonNull,
  GraphQLInt,
} from 'graphql';

const DeviceType = new GraphQLObjectType({
  name: 'DeviceType',
  fields: {
    id: { type: new GraphQLNonNull(GraphQLString) },
    creationTimestamp: { type: new GraphQLNonNull(GraphQLInt) },
    name: { type: new GraphQLNonNull(GraphQLString) },
    permissions: { type: new GraphQLNonNull(new GraphQLList(new GraphQLNonNull(GraphQLString))) },
    isActive: { type: GraphQLBoolean },
  }
});

const DeviceMutations = new GraphQLObjectType({
  name: 'DeviceMutations',
  fields: {
    create: {
      type: DeviceType,
      args: {
        name: { type: new GraphQLNonNull(GraphQLString) },
        permissions: { type: new GraphQLList(new GraphQLNonNull(GraphQLString)) }
      },
      async resolve(_parent, { name, permissions }) {
        const device = new Device({ name: name, permissions: permissions ?? [] });
        device.save();
        return {
          id: device._id,
          creationTimestamp: device._id.getTimestamp(),
          name: device.name,
          permissions: device.permissions,
          isActive: false
        }
      }
    },
    generateToken: {
      type: GraphQLString,
      args: {
        id: { type: new GraphQLNonNull(GraphQLString) }
      },
      async resolve(_parent, { id }) {
        const device = (await Device.findById(new mongoose.Types.ObjectId(id)));
        if (device !== null)
          return await new SignJWT({})
            .setProtectedHeader({ alg: 'RS256', typ: 'JWT' })
            .setSubject(id)
            .setIssuedAt()
            .sign(PrivateKey);
        return null;
      }
    }
  }
})

const Schema = new GraphQLSchema({
  query: new GraphQLObjectType({
    name: 'RootQueryType',
    fields: {
      devices: {
        type: new GraphQLList(DeviceType),
        async resolve() {
          return (await Device.find({})).map(device => ({
            id: device._id,
            creationTimestamp: device._id.getTimestamp(),
            name: device.name,
            permissions: device.permissions,
            isActive: false
          }));
        },
      },
    },
  }),
  mutation: new GraphQLObjectType({
    name: 'RootMutationType',
    fields: {
      device: {
        type: DeviceMutations,
        resolve: () => ({})
      }
    }
  })
});

/** @typedef {import('ws').WebSocket} WebSocket */
/** @typedef {import('ws').RawData} RawData */

/** @typedef {Command & { id: number }} FullCommand */
class Command {
  /**
   * @param {string} context
   * @param {any=} payload
   */
  constructor(context, payload) {
    this.context = context;
    this.payload = payload;
  }
}

class ErrorCommand extends Command {
  /**
   * @param {string} message
   * @param {string} packet
   */
  constructor(message, packet) {
    super('error', { message, packet });
  }
}

class ResponseCommand extends Command {
  /**
   * @param {FullCommand} incomingCommand
   * @param {Command} outgoingCommand
   */
  constructor(incomingCommand, outgoingCommand) {
    super('response', { responseTo: incomingCommand.id, response: outgoingCommand });
  }
}

class ErrorResponseCommand extends ResponseCommand {
  /**
   * @param {FullCommand} incomingCommand
   * @param {string} message
   * @param {string} packet
   */
  constructor(incomingCommand, message, packet) {
    super(incomingCommand, new ErrorCommand(message, packet));
  }
}

export class WebConnection {
  /** @param {WebSocket} ws */
  constructor(ws) {
    this.ws = ws;
    /** @type {Command[]} */
    this.sentCommandHistory = [];
    this.authenticated = false;
    ws.on('message', this.onMessage.bind(this));
    ws.on('error', () => { });
  }

  /**
    * @private
    * @param {Command} command
    */
  sendCommand(command) {
    /** @type {FullCommand} */
    (command).id = this.sentCommandHistory.length;
    this.sentCommandHistory.push(command);
    this.ws.send(JSON.stringify(command));
  }

  /** @param {RawData} data */
  onMessage(data) {
    if (!(data instanceof Buffer)) throw 'Unexpected binary type';

    /** @type {FullCommand} */
    let command;
    try { command = JSON.parse(data.toString()); } catch {
      return this.sendCommand(new ErrorCommand('Bad JSON', data.toString()));
    }

    if (!(
      'id' in command &&
      'context' in command &&
      command.id !== undefined
    )) return this.sendCommand(new ErrorCommand('Bad Command', data.toString()));

    switch (command.context) {
      case 'auth': {
        if (typeof command.payload !== 'string') return this.sendCommand(new ErrorResponseCommand(command, 'Bad Payload', data.toString()));
        jwtVerify(command.payload, PublicKey).then(
          jwt => {
            if (!jwt.payload.exp) return this.sendCommand(new ErrorResponseCommand(command, 'No Expiration', data.toString()));
            this.sendCommand(new ResponseCommand(command, new Command('success')));
          },
          () => this.sendCommand(new ErrorResponseCommand(command, 'Invalid Token', data.toString()))
        );
        break;
      }
      case 'graphql': {
        if (typeof command.payload !== 'string') return this.sendCommand(new ErrorResponseCommand(command, 'Bad Payload', data.toString()));
        graphql({ schema: Schema, source: command.payload })
          .then(result => this.sendCommand(new ResponseCommand(command, new Command('data', result))));
        break;
      }
      default: this.sendCommand(new ErrorResponseCommand(command, 'Invalid Context', data.toString()));
    }
  }
}

/** @param {WebSocket} ws The websocket to the device */
export default function handleWebConnection(ws) {
  new WebConnection(ws);
}