'use strict';

import { getRoutes } from '../../utils.js'
import handleAPI from './apiRoutesHandler.js';
import { readFile } from 'node:fs/promises';
import { parse } from 'node:url';

/** @typedef {{[key: string]: Buffer | Promise<Buffer>}} Files */

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
    async get(_target, prop, _receiver) {
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
      case '/favicon.ico': // TODO: favicon
        return res.writeHead(404, 'Not Found').end();
      case '/':
        return res.writeHead(200, { 'Content-Type': 'text/html' })
          .end(await PUBLIC['pages/index.html']);
      default:
        if (pathname?.startsWith('/api/'))
          return handleAPI(req, res, pathname);

        if (!(
          pathname?.startsWith('/pages/') ||
          pathname?.startsWith('/assets/') ||
          pathname?.startsWith('/styles/') ||
          pathname?.startsWith('/scripts/')
        )) break;

        const fileType =
          pathname?.startsWith('/assets/') ? 'image/svg+xml' :
            pathname?.startsWith('/pages/') ? 'text/html' :
              pathname?.startsWith('/styles/') ? 'text/css' :
                pathname?.startsWith('/scripts/') ? 'text/javascript' :
                  '*';

        return await (async () => await PUBLIC[pathname.slice(1)])().then(
          file => res.writeHead(200, { 'Content-Type': fileType }).end(file),
          () => res.writeHead(404, 'Not Found').end()
        );
    }
    return res.writeHead(404, 'Not Found').end();
  }
  return res.writeHead(400, 'Bad Request').end();
}