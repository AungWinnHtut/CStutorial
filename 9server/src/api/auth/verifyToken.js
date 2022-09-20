'use strict';

import { jwtVerify } from 'jose';
import { PublicKey } from '../../handlers/internal/configHandler.js';

/**
 * @typedef {import('../../handlers/server/httpRequestHandler').RequestHandler} RequestHandler
 * @type {RequestHandler}
 */
export default async function verifyToken(req, res) {
  return await new Promise(resolve =>
    req.once('data', async dataBuffer => {
      if (!(dataBuffer instanceof Buffer)) return resolve(res.writeHead(500, 'Internal Server Error').end());
      jwtVerify(dataBuffer, PublicKey).then(
        jwt => {
          if (!jwt.payload.exp) return resolve(res.writeHead(401, 'Unauthorized').end());
          resolve(res.writeHead(200, 'OK').end());
        },
        () => resolve(res.writeHead(401, 'Unauthorized').end())
      );
    })
  );
}