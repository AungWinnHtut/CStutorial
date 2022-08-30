'use strict';

/**
 * @typedef {import('../handlers/server/httpRequestHandler').RequestHandler} RequestHandler
 * @type {RequestHandler}
 */
export default function helloWorld(req, res) {
  req; // to disable unused variable warning

  return res.writeHead(200, { 'Content-Type': 'application/json' })
    .end(JSON.stringify({ hello: 'world' }));
}