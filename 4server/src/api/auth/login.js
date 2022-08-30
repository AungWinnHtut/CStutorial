'use strict';

import { getServerConfig } from '../../handlers/internal/configHandler.js';
import bcrypt from 'bcryptjs';

const SERVER_CONFIG = getServerConfig();

/**
 * @typedef {import('../../handlers/server/httpRequestHandler').RequestHandler} RequestHandler
 * @type {RequestHandler}
 */
export default async function helloWorld(req, res) {
  return await new Promise((resolve, reject) =>
    req.once('data', async dataBuffer => {
      if (!(dataBuffer instanceof Buffer)) return resolve(res.writeHead(500, 'Internal Server Error').end());
      /** @type {{ username: string, password: string}} */
      let data;
      try { data = JSON.parse(dataBuffer.toString()); } catch {
        return resolve(res.writeHead(400, 'Bad Request').end());
      }

      if (!('username' in data && 'password' in data)) return resolve(res.writeHead(400, 'Bad Request').end());

      if (data.username === 'root' && !SERVER_CONFIG.disableServerForcedRoot)
        if (await bcrypt.compare(data.password, SERVER_CONFIG.serverForcedRootPasswordHashed))
          return resolve(res.writeHead(200, { 'Content-Type': 'application/json' })
            .end(JSON.stringify({ hello: 'world' })));
        else return resolve(res.writeHead(401, 'Unauthorized').end());

      // TODO: handle non root accounts

      return resolve(res.writeHead(501, 'Not Implemented').end());
    })
  );
}