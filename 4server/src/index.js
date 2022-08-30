'use strict';

import { getServerConfig } from './handlers/internal/configHandler.js';
import chalk from 'chalk';
import chokidar from 'chokidar'
import { createServer } from 'node:http';
import { WebSocketServer } from 'ws';

//import('./handlers/internal/database/databaseHandler.js')

// /^\$2[ayb]\$.{56}$/ bcrypt

const SERVER_CONFIG = getServerConfig();
let handleHttpRequest = (await import('./handlers/server/httpRequestHandler.js')).default;
let handleDeviceConnection = (await import('./handlers/server/device/deviceConnectionHandler.js')).default;

// TODO: https
new WebSocketServer({
  server: createServer(async (req, res) => await handleHttpRequest(req, res))
    .listen(
      SERVER_CONFIG.listenPort,
      SERVER_CONFIG.listenHostname,
      () => console.log(chalk.greenBright('Server listening'))
    ),
  path: '/connectdevice',
}).on('connection', ws => handleDeviceConnection(ws));

// Handle all exceptions
process.on('uncaughtException', e =>
  console.error(chalk.redBright(`[unhandledException] ${e.stack ?? `${e.name} ${e.message}`}`))
);

// Hot reload requestHandler for development
if (process.argv.includes('--dev')) {
  console.warn(chalk.yellowBright('Running in development mode'));

  chokidar.watch('src/handlers/server/httpRequestHandler.js').on('change', () =>
    import(`./handlers/server/httpRequestHandler.js?v=${Date.now()}`).catch().then(v => handleHttpRequest = v.default)
  );

  chokidar.watch('src/handlers/server/deviceConnectionHandler.js').on('change', () =>
    import(`./handlers/server/deviceConnectionHandler.js?v=${Date.now()}`).catch().then(v => handleDeviceConnection = v.default)
  );
}