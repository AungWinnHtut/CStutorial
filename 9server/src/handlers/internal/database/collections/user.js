'use strict';

import mongoose from 'mongoose';
import bcrypt from 'bcryptjs';

/** @param {mongoose.Connection} conn */
export default function createUserModel(conn) {
  /**
   * @typedef IUser
   * @property {string} name
   * @property {string} password
   */
  /** @type {mongoose.Schema<IUser, UserModel, IUserMethods, {}, {}, {}>} */
  const userSchema = new mongoose.Schema({
    name: { type: String, required: true, unique: true },
    password: { type: String, required: true },
  });

  /**
   * @typedef IUserMethods
   * @property {(password: string) => Promise<boolean>} verifyPassword
   */
  /**
   * @this {InstanceType<UserModel>}
   * @param {string} password
   */
  userSchema.methods['verifyPassword'] = async function (password) {
    return await bcrypt.compare(password, this.password)
  };
  
  /**
   * @typedef {import('mongoose').Model<IUser, {}, IUserMethods, {}> & {
   *   new: (name: string, password: string) => Promise<InstanceType<UserModel>>
   * }} UserModel
   */
  /**
   * @param {string} name
   * @param {string} password
   * @returns {Promise<InstanceType<UserModel>>}
   */
  userSchema.statics['new'] = async (name, password) => createUser(name, password);
  
  const User = conn.model('users', userSchema);
  /**
   * @param {string} name
   * @param {string} password
   */
  async function createUser(name, password) {
    return new User({
      name,
      password: await bcrypt.hash(password, 10)
    });
  }

  return User;
}