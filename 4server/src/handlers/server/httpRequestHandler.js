'use strict';

import { getRoutes } from '../../utils.js'
import handleAPI from './apiRoutesHandler.js';
import { readFile } from 'node:fs/promises';
import { parse } from 'node:url';
import cookie from 'cookie';
import { getServerConfig } from '../internal/configHandler.js';

const SERVER_CONFIG = getServerConfig();
/** @typedef {{[key: string]: Buffer}} Files */

async function getStaticFiles() {
  return /** @type {Files} */ (
    Object.assign({},
      ...await Promise.all((await getRoutes('public'))
        .map(async route => (
          { [route.slice(7)]: await readFile(route) }
        ))
      )
    )
  )
}

const PUBLIC = process.argv.includes('--dev') ?
  new Proxy(/** @type {Files} */({}), {
    async get(target, prop, receiver) {
      return await readFile(`public/${prop.toString()}`)
    }
  }) : await getStaticFiles();

/**
 * @typedef {import('node:http').IncomingMessage} IncomingMessage
 * @typedef {import('node:http').ServerResponse} ServerResponse
 * @typedef {(req: IncomingMessage, res: ServerResponse) => Promise<ServerResponse> | ServerResponse} RequestHandler
 * @type {RequestHandler}
 */
export default async function handleHttpRequest(req, res) {
  if (req.url) {
    const { pathname } = parse(req.url, false);
    switch (pathname) {
      case '/favicon.ico':
        // TODO: favicon
        return res.writeHead(404, 'Not Found').end();
      case '/':
        //if (!req.headers.cookie)
        //  return res.writeHead(302, 'Found', { 'Location': '/login' }).end();
        return res.writeHead(200, { 'Content-Type': 'text/html' }).end(await PUBLIC['index.html']);
      case '/index.js':
        //if (!req.headers.cookie)
        //  return res.writeHead(302, 'Found', { 'Location': '/login' }).end();
        return res.writeHead(200, { 'Content-Type': 'text/javascript' }).end(await PUBLIC['index.js']);
      case '/index.css':
        //if (!req.headers.cookie)
        //  return res.writeHead(302, 'Found', { 'Location': '/login' }).end();
        return res.writeHead(200, { 'Content-Type': 'text/css' }).end(await PUBLIC['index.css']);
      case '/login':
        return res.writeHead(200, { 'Content-Type': 'text/html' }).end(await PUBLIC['login.html']);
      case '/login.js':
        return res.writeHead(200, { 'Content-Type': 'text/javascript' }).end(await PUBLIC['login.js']);
      case '/login.css':
        return res.writeHead(200, { 'Content-Type': 'text/css' }).end(await PUBLIC['login.css']);
      case '/styles.css':
        return res.writeHead(200, { 'Content-Type': 'text/css' }).end(await PUBLIC['styles.css']);
      default:
        if (pathname?.startsWith('/api'))
          return handleAPI(req, res, pathname);
    }
    return res.writeHead(404, 'Not Found').end();
  }
  return res.writeHead(400, 'Bad Request').end();
}