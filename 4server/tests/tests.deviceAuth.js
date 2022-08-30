'use strict';

import WebSocket from "ws";

const ws = new WebSocket('ws://127.0.0.1:3000/connectdevice').on('open', () => {
  const commandID = 0;
  const commandContext = 0;
  const commandPayload = "Hello World";

  const commandIDBuffer = new Uint8Array((() => {
    const buffer = [...new Uint8Array(new Uint32Array([commandID]).buffer).reverse()];
    while (!buffer[0] && buffer.length > 1) buffer.shift();
    return buffer;
  })());

  const firstByteBuffer = new Uint8Array([commandIDBuffer.length - 1]);
  const commandContextBuffer = new Uint8Array(new Uint16Array([commandContext]).buffer).reverse();
  const commandPayloadBuffer = Buffer.from(commandPayload);

  ws.send(Uint8Array.from([...firstByteBuffer, ...commandIDBuffer, ...commandContextBuffer, ...commandPayloadBuffer]));
});