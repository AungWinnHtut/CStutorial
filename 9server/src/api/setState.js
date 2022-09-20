'use strict';

import { States } from '../handlers/internal/database/databaseHandler.js';

/**
 * @typedef {import('../handlers/server/httpRequestHandler').RequestHandler} RequestHandler
 * @type {RequestHandler}
 */
export default async function helloWorld(req, res) {
  return await new Promise(resolve =>
    req.once('data', async dataBuffer => {
      if (!(dataBuffer instanceof Buffer)) return resolve(res.writeHead(500, 'Internal Server Error').end());

      const data = dataBuffer.toString();
      /** @type {{ [key: string]: number }} */
      let setState;
      try { setState = JSON.parse(data); } catch {
        return resolve(res.writeHead(400, 'Bad Request').end());
      }

      for (const stateID in setState)
        if (!(stateID in States)) return resolve(res.writeHead(404, 'Not Found').end(JSON.stringify(stateID)));

      for (const stateID in setState) {
        const state = States[stateID];
        const newState = setState[stateID];
        if (state === undefined || newState === undefined) return;

        state.state = newState;
        for (const device of state.devices)
          device.sendState(stateID, newState);
      }
      resolve(res.writeHead(200, 'OK').end());
    })
  );
}