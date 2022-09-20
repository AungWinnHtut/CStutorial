/// <reference lib="dom" />
'use strict';

export class Command {
  /**
   * @param {string} context
   * @param {any=} payload
   */
  constructor(context, payload) {
    this.context = context;
    this.payload = payload;
  }
}

/**
 * @typedef {Command & { id: number }} FullCommand
 * @typedef {Omit<FullCommand, 'payload'> & {
 *   payload: {
 *     responseTo: number,
 *     response: Command
 *   }
 * }} ResponseCommand
*/

export default class ConnectionHandler extends EventTarget {
  /** @readonly @type {WebSocket} */ #ws;
  /** @readonly @type {[Command, (command: Command) => void][]} */ #sentCommandHistory = [];

  /**
   * @param {string} url
   * @param {string} token
  */
  constructor(url, token) {
    super();
    /** @readonly */ this.url = url;
    /** @readonly */ this.token = token;

    /** @type {(value: boolean) => void} */ let authResolve;
    /** @readonly @type {Promise<boolean>} */
    this.authenticationResult = new Promise(resolve => authResolve = resolve);
    this.#ws = new WebSocket('ws://127.0.0.1:3000/connectwebclient');

    this.#ws.addEventListener('open', (async () => {
      const response = await this.sendCommand(new Command('auth', token));
      switch (response.context) {
        case 'success': return authResolve(true);
        case 'error': return authResolve(false);
      }
      return;
    }).bind(this));
    this.#ws.addEventListener('message', this.onMessage.bind(this));
  }

  /** @param {Command} command */
  async sendCommand(command) {
    /** @type {FullCommand} */
    (command).id = this.#sentCommandHistory.length;

    return await /** @type {Promise<Command>} */
      (new Promise(resolve => {
        this.#sentCommandHistory.push([command, resolve]);
        this.#ws.send(JSON.stringify(command));
      }));
  }

  /** @param {MessageEvent<any>} e */
  onMessage(e) {
    /** @type {Command} */
    const command = JSON.parse(e.data);
    console.log(command)
    switch (command.context) {
      case 'response': {
        this.#sentCommandHistory[
          /** @type {ResponseCommand} */
          (command).payload.responseTo
        ]?.[1](
          /** @type {ResponseCommand} */
          (command).payload.response
        );
        break;
      }
    }
  }
}