'use strict';

import mongoose from 'mongoose';

/** @param {mongoose.Connection} conn */
export default function createDeviceModel(conn) {
  /**
   * @typedef IDevice
   * @property {string} name
   * @property {mongoose.Types.ObjectId[]} permissions
   */
  /** @type {mongoose.Schema<IDevice, DeviceModel, IDeviceMethods, {}, {}, {}>} */
  const deviceSchema = new mongoose.Schema({
    name: { type: String, required: true },
    permissions: { type: [mongoose.Types.ObjectId], required: true },
  });

  /**
   * @typedef {{}} IDeviceMethods
   */

  /**
   * @typedef {mongoose.Model<IDevice, {}, IDeviceMethods, {}> & {}} DeviceModel
   */

  /** @type {DeviceModel}  */
  const Device = conn.model('devices', deviceSchema);

  return Device;
}