'use strict';

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

export function getIfDevMode() { return process.argv.includes('--dev') }