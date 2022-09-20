'use strict';

import { randomInt } from "node:crypto";
import WebSocket from "ws";

const humidityDataCollectionID = '6306024fd2a6f70702fe46c8'
const temperatureDataCollectionID = '63060250d2a6f70702fe46c9'

const ws = new WebSocket('ws://127.0.0.1:80/connectdevice').on('open', () => {
  let commandID = 0;

  /**
   * @param {number} commandContext
   * @param {Buffer} commandPayloadBuffer
   */
  function sendCommand(commandContext, commandPayloadBuffer) {
    const commandIDBuffer = new Uint8Array((() => {
      const buffer = [...new Uint8Array(new Uint32Array([commandID++]).buffer).reverse()];
      while (!buffer[0] && buffer.length > 1) buffer.shift();
      return buffer;
    })());

    const firstByteBuffer = new Uint8Array([commandIDBuffer.length - 1]);
    const commandContextBuffer = new Uint8Array(new Uint16Array([commandContext]).buffer).reverse();

    ws.send(Uint8Array.from([...firstByteBuffer, ...commandIDBuffer, ...commandContextBuffer, ...commandPayloadBuffer]));
  }

let started = false;

  ws.on('message', data => {
    if (!(data instanceof Buffer)) throw 'Unexpected binary type';
    //if (data[data.length - 1] != 0) return console.error(`Server returned error code: ${data[data.length - 0]}`);
    if (started) return;
    setInterval(() => {
      sendCommand(0x0002, Buffer.from([humidityDataCollectionID.length, ...Buffer.from(humidityDataCollectionID), randomInt(20)]));
      sendCommand(0x0002, Buffer.from([temperatureDataCollectionID.length, ...Buffer.from(temperatureDataCollectionID), randomInt(20)]));
    }, 1000)
    started = true;
  });

  sendCommand(0x0000, Buffer.from('token'))
});