'use strict';

import { DatabaseConfig } from '../configHandler.js';
import mongoose from 'mongoose';
import createUserModel from './collections/user.js';
import createDataCollectionModel from './collections/dataCollection.js';
import { isDevMode } from '../../../utils.js';
import chalk from 'chalk';
import createDeviceModel from './collections/device.js';

// FIXME: double slash after URI problem
const conn = await /** @type {Promise<mongoose.Connection>} */ (new Promise(async resolve => {
  console.info(chalk.cyanBright('Connecting to MongoDB'));

  let madeInitialConnection = false;
  const conn = mongoose.createConnection(`${DatabaseConfig.mongodbURI}/${DatabaseConfig.mongodbDatabase}`)
    .once('connected', () => {
      madeInitialConnection = true;
      console.info(chalk.greenBright('Connected to MongoDB'));
      resolve(conn);
    })
    .on('disconnected', () => {
      console.warn(chalk.red('Disconnected from MongoDB'));
      console.warn(chalk.yellow('Attempting to reconnect'));
      //if (!madeInitialConnection)
      //conn.openUri(`${DatabaseConfig.mongodbURI}/${DatabaseConfig.mongodbDatabase}`).;
    })
    .on('reconnected', () =>
      console.info(chalk.greenBright('Reconnected to MongoDB'))
    );
}));

export const Device = isDevMode ?
  new Proxy(createDeviceModel(conn), {
    //  get(target, prop, receiver) {
    //    if (getIfDevMode())
    //      return "world";
    //  }
  }) : createDeviceModel(conn);

//let userModel = 

/** @typedef {ReturnType<createUserModel>} UserModel */
/** @type {{ [P in keyof UserModel]: UserModel[P] | Promise<UserModel[P]>; }} */
export const User = new Proxy(createUserModel(conn), {
  //get(target, prop, receiver) {
  //  if (getIfDevMode())
  //    return "world";
  //}
});

// /** @typedef {ReturnType<createDataCollectionModel>} DataCollectionModel */
// /** @type {{ [P in keyof DataCollectionModel]: DataCollectionModel[P] | Promise<DataCollectionModel[P]>; }} */
// const DataCollection = new Proxy(createDataCollectionModel(conn), {
//   get(target, prop, receiver) {
//     if (getIfDevMode())
//     return "world";
//   }
// });

/** @type {{ [key: string]: [Date, number][] }} */
export const DataCollections = {
  '6306024fd2a6f70702fe46c8': [],
  '63060250d2a6f70702fe46c9': []
}

/** 
 * @type {{
 *   [key: string]: {
 *     name: string,
 *     states: string[],
 *     state: number,
 *     devices: import('../../server/device/deviceConnectionHandler.js').DeviceConnection[];
 *   }
 * }}
 */
export const States = {
  '6315f46447ad6406cfd96d5a': { name: 'Light', states: ['off', 'on'], state: 0, devices: [] }
}