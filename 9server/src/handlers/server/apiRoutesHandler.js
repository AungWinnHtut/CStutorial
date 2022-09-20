'use strict';

import { getRoutes } from '../../utils.js';

/** @typedef {import('./httpRequestHandler').RequestHandler} RequestHandler */
/** @typedef {{[key: string]: RequestHandler | Promise<RequestHandler>}} Routes */

async function getApiRoutes() {
  return /** @type {Routes} */ (
    Object.assign({},
      ...await Promise.all((await getRoutes('src/api'))
        .map(async route => (
          {
            [route.slice(3, -3)]: /** @type {RequestHandler} */
              ((await import(`../..${route.slice(3)}`)).default)
          }
        ))
      )
    )
  )
}

const ROUTES = process.argv.includes('--dev') ?
  new Proxy(/** @type {Routes} */({}), {
    async get(_target, prop, _receiver) {
      return (await import(`../..${prop.toString()}.js?v=${Date.now()}`)).default
    }
  }) : await getApiRoutes();

/**
 * @type {RequestHandler}
 * @param {string=} path
 */
export default async function handleAPI(req, res, path) {
  // path is an optional value as it can be obtained from req.url
  // path should be handled here if it is not provided, currently it is always provided
  if (!path) return res.writeHead(500).end();
  return (await (await ROUTES[path])?.(req, res)) ?? res.writeHead(404, 'Not Found').end();
}