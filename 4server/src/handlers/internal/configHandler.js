'use strict';

/**
 * Importing JSON modules is an experimental feature
 * @see https://github.com/tc39/proposal-import-assertions
 * 
 * import <configName> from '../../configs/<configName>.json' assert { type: 'json' };
 */

import { createRequire } from "module";
const require = createRequire(import.meta.url);

/**
 * @returns {{
 *   listenHostname: string,
 *   listenPort: number,
 *   disableServerForcedRoot: boolean,
 *   serverForcedRootPasswordHashed: string,
 * }} The configuration for the web server
 */
export function getServerConfig() {
  return require('../../../configs/server.json');
}

/**
 * @returns {{
 *   mongodbURI: string,
 *   mongodbDatabase: string,
 * }} The configuration for the database connection
 */
export function getDatabaseConfig() {
  return require('../../../configs/database.json');
}