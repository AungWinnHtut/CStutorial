'use strict';

// Handle all exceptions
process.on('uncaughtException', e =>
  console.error(chalk.redBright(`[unhandledException] ${e.stack ?? `${e.name} ${e.message}`}`))
);

import { ServerConfig } from './handlers/internal/configHandler.js';
import chalk from 'chalk';
import { createServer } from 'node:http';
import { WebSocketServer } from 'ws';
import { hotReload } from './utils.js';
import { parse } from 'node:url';

/** @type {{module: import('./handlers/server/httpRequestHandler.js').default}} */
let handleHttpRequest = await hotReload('handlers/server/httpRequestHandler.js');
/** @type {{module: import('./handlers/server/device/deviceConnectionHandler.js').default}} */
let handleDeviceConnection = await hotReload('handlers/server/device/deviceConnectionHandler.js');
/** @type {{module: import('./handlers/server/webclient/webConnectionHandler.js').default}} */
let handleWebConnection = await hotReload('handlers/server/webclient/webConnectionHandler.js');

const deviceWs = new WebSocketServer({ noServer: true });
const webClientWs = new WebSocketServer({ noServer: true });

// TODO: https
createServer(async (req, res) => await handleHttpRequest.module(req, res)).listen(
  ServerConfig.listenPort,
  ServerConfig.listenHostname,
  () => console.info(chalk.greenBright('Server listening'))
).on('upgrade', (request, socket, head) => {
  if (!request.url) return;
  switch (parse(request.url).pathname) {
    case '/connectdevice': return deviceWs.handleUpgrade(request, socket, head, ws => handleDeviceConnection.module(ws));
    case '/connectwebclient': return webClientWs.handleUpgrade(request, socket, head, ws => handleWebConnection.module(ws));
  }
});

// Warn for development mode
if (process.argv.includes('--dev'))
  console.warn(chalk.yellowBright('Running in development mode'));