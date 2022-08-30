'use strict';

import { getDatabaseConfig } from '../configHandler.js';
import mongoose from 'mongoose';
import createUserModel from './collections/user.js';
import createDataCollectionModel from './collections/dataCollection.js';
import { getIfDevMode } from '../../../utils.js';

const DB_CONFIG = getDatabaseConfig();

// FIXME: double slash after URI problem
const conn = await mongoose.createConnection(`${DB_CONFIG.mongodbURI}/${DB_CONFIG.mongodbDatabase}`);

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
  //get(target, prop, receiver) {
  //  if (getIfDevMode())
  //    return "world";
  //}
// });

/** @type {{ [key: string]: [Date, number][] }} */
export const DataCollections = {
  '6306024fd2a6f70702fe46c8': [],
  '63060250d2a6f70702fe46c9': []
}

