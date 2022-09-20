'use strict';

import { DataCollections } from '../handlers/internal/database/databaseHandler.js';
//import { DataCollections } from '../handlers/server/deviceConnectionHandler.js';

/**
 * @typedef {import('../handlers/server/httpRequestHandler').RequestHandler} RequestHandler
 * @type {RequestHandler}
 */
export default function helloWorld(req, res) {
  /** @type {{ [key: string]: string }} */
  const params = {};

  req.url?.match(/[^&?]*?=[^&?]*/g)?.forEach(p =>
    params[p.split('=')[0] ?? ''] = p.split('=')[1] ?? ''
  );

  if (!(params['col'] && params['col'] in DataCollections && params['dat']))
    return res.writeHead(400, 'Bad Request', { 'Content-Type': 'application/json' })
      .end('400 Bad Request');

  DataCollections[params['col']]?.push([new Date(), Number(params['dat'])]);
  return res.writeHead(200, 'OK', { 'Content-Type': 'application/json' })
    .end(JSON.stringify(DataCollections));
}