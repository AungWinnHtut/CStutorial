'use strict';

import { PrivateKey, ServerConfig } from '../../handlers/internal/configHandler.js';
import bcrypt from 'bcryptjs';
import { SignJWT } from 'jose';

/**
 * @typedef {import('../../handlers/server/httpRequestHandler').RequestHandler} RequestHandler
 * @type {RequestHandler}
 */
export default async function helloWorld(req, res) {
  return await new Promise(resolve =>
    req.once('data', async dataBuffer => {
      if (!(dataBuffer instanceof Buffer)) return resolve(res.writeHead(500, 'Internal Server Error').end());
      /** @type {{ username: string, password: string}} */
      let data;
      try { data = JSON.parse(dataBuffer.toString()); } catch {
        return resolve(res.writeHead(400, 'Bad Request').end());
      }

      if (!(
        typeof data === 'object' &&
        'username' in data &&
        'password' in data
      )) return resolve(res.writeHead(400, 'Bad Request').end());

      if (data.username === 'root' && !ServerConfig.disableServerForcedRoot)
        if (await bcrypt.compare(data.password, ServerConfig.serverForcedRootPasswordHashed))
          return resolve(res.writeHead(200, 'OK', { 'Content-Type': 'text/jwt' })
            .end(await new SignJWT({ 'username': 'root' })
              .setProtectedHeader({ alg: 'RS256', typ: 'JWT' })
              .setSubject('root')
              .setIssuedAt()
              .setExpirationTime('1h')
              .sign(PrivateKey)
            )
          );
        else return resolve(res.writeHead(401, 'Unauthorized').end());

      // TODO: handle non root accounts

      return resolve(res.writeHead(501, 'Not Implemented').end());
    })
  );
}