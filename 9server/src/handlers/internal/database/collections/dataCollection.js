'use strict';

import mongoose from 'mongoose';
import bcrypt from 'bcryptjs';

/** @param {mongoose.Connection} conn */
export default function createDataCollectionModel(conn) {
  const options = { discriminatorKey: 'kind' };

  /**
   * @typedef IDataCollection
   * @property {string} name
   * @property {[mongoose.Schema]} documents
   */
  /** @type {mongoose.Schema<IDataCollection, DataCollectionModel, IDataCollectionMethods, {}, {}, {}>} */
  const dataCollectionSchema = new mongoose.Schema({
    name: { type: mongoose.Schema.Types.String },
    documents: [new mongoose.Schema()],
  }, options);
  console.log(JSON.stringify({
    name: { type: mongoose.Schema.Types.String },
  }))

  console.log(mongoose.Schema.Types.String);
  /**
   * @typedef {{}} IDataCollectionMethods
   */

  /**
   * @typedef {import('mongoose').Model<IDataCollection, {}, IDataCollectionMethods, {}>} DataCollectionModel
   */
console.dir
  const DataCollection = conn.model('datacollections', dataCollectionSchema);

  //const asdf = DataCollection.discriminator('asdf', new mongoose.Schema({ url: String }, options))
  //const test = new asdf({ url: 'test' });

  //console.log(test);
  
  return DataCollection;
}