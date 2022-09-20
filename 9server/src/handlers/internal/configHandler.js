'use strict';

/**
 * Importing JSON modules is an experimental feature
 * @see https://github.com/tc39/proposal-import-assertions
 * 
 * import <configName> from '../../configs/<configName>.json' assert { type: 'json' };
 */

import { importJWK } from "jose";
import { createRequire } from "module";
const require = createRequire(import.meta.url);

/**
 * @type {{
 *   listenHostname: string,
 *   listenPort: number,
 *   disableServerForcedRoot: boolean,
 *   serverForcedRootPasswordHashed: string,
 * }}
 */
export const ServerConfig = require('../../../configs/server.json');

/**
 * @type {{
 *   mongodbURI: string,
 *   mongodbDatabase: string,
 * }}
 */
export const DatabaseConfig = require('../../../configs/database.json');

export const PublicKey = await importJWK(require('../../../configs/publicKey.json'), 'RSA');
export const PrivateKey = await importJWK(require('../../../configs/privateKey.json'), 'RSA');

/** @returns {typeof ServerConfig} The configuration for the web server */
export function getServerConfig() {
  return require('../../../configs/server.json');
}

/** @returns {typeof DatabaseConfig} The configuration for the database connection */
export function getDatabaseConfig() {
  return require('../../../configs/database.json');
}