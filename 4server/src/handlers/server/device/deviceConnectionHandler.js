'use strict';

import { DataCollections } from '../../internal/database/databaseHandler.js';

/** @typedef {import('ws').WebSocket} WebSocket */
/** @typedef {import('ws').RawData} RawData */

class DeviceConnection {
  /** @param {WebSocket} ws */
  constructor(ws) {
    this.commandID = 0;
    this.authenticated = false;
    this.ws = ws;
    ws.on('message', data => this.onMessage(data));
  }

  /**
   * @private
   * @param {number} context Command Context
   * @param {Buffer} payloadBuffer Command Payload
   */
  async sendCommand(context, payloadBuffer) {
    const commandIDBuffer = new Uint8Array((() => {
      const buffer = [...new Uint8Array(new Uint32Array([this.commandID++]).buffer).reverse()];
      while (!buffer[0] && buffer.length > 1) buffer.shift();
      return buffer;
    })());

    const firstByteBuffer = new Uint8Array([commandIDBuffer.length - 1]);
    const commandContextBuffer = new Uint8Array(new Uint16Array([context]).buffer).reverse();

    this.ws.send([
      ...firstByteBuffer,
      ...commandIDBuffer,
      ...commandContextBuffer,
      ...payloadBuffer
    ])
  }

  /** @param {RawData} data */
  async onMessage(data) {
    if (!(data instanceof Buffer)) throw 'Unexpected binary type';

    const firstByte = data[0];
    if (firstByte === undefined || data.length < (firstByte + 4)) return; // TODO: Error command

    const commandID = data.readUintBE(1, firstByte + 1);
    const commandContext = data.readUint16BE(firstByte + 2);
    const commandPayload = data.subarray(4);

    if (!this.authenticated && commandContext !== 0x0000) return; // TODO: Error ommand
    console.log(...data)
    switch (commandContext) {
      case 0x0000:
        //console.log(`Auth: ${data.toString('utf-8', firstByte + 4)}`)
        this.authenticated = true;
        this.sendCommand(0x0001, Buffer.from(new Uint8Array([firstByte, ...data.subarray(1, firstByte + 2), 0]).buffer));
        break;
      case 0x0001:
        // TODO: Status command
        // first byte, command id, status code
        break;
      case 0x0002:
        if (commandPayload[0] === undefined)
          return this.sendCommand(0x0001, Buffer.from(new Uint8Array([firstByte, ...data.subarray(1, firstByte + 2), 1]).buffer));

        const dbid = Buffer.from(commandPayload.subarray(1, commandPayload[0] + 1)).toString();
        if (!(dbid in DataCollections)) return this.sendCommand(0x0001, Buffer.from(new Uint8Array([firstByte, ...data.subarray(1, firstByte + 2), 2]).buffer));

        DataCollections[dbid]?.push([new Date(), commandPayload.readUintBE(commandPayload[0] + 1, commandPayload.length - (commandPayload[0] + 1))]);
        this.sendCommand(0x0001, Buffer.from(new Uint8Array([firstByte, ...data.subarray(1, firstByte + 2), 0]).buffer));
        break;
      default:
        // TODO: Error command
        break;
    }
  }
}

/** @param {WebSocket} ws The websocket to the device */
export default function handleDeviceConnection(ws) {
  new DeviceConnection(ws);
}