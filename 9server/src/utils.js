'use strict';

import chokidar from 'chokidar';
import { readdir, stat } from 'node:fs/promises';

/** @typedef {[string | Routes]} Routes */

/**
 * @param {string} path The path of the directory to get routes of
 * @returns {Promise<string[]>}
 */
export async function getRoutes(path) {
  /** @type {string[]} */
  const ROUTES = [];
  for (const file of await readdir(path))
    if ((await stat(`${path}/${file}`)).isDirectory())
      ROUTES.push(...await getRoutes(`${path}/${file}`));
    else ROUTES.push(`${path}/${file}`);

  return ROUTES;
}

export const isDevMode = process.argv.includes('--dev');

/**
 * @param {string} path
 * @param {boolean=} force
*/
export async function hotReload(path, force) {
  if (!isDevMode && !force) return { module: (await import(`./${path}`)).default };
  const RETURN = { module: (await import(`./${path}?v=${Date.now()}`)).default };

  chokidar.watch(`src/${path}`).on('change', async () =>
    import(`./${path}?v=${Date.now()}`).then(v => RETURN.module = v.default, () => { })
  );

  return RETURN;
}