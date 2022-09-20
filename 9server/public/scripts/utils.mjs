/**
 * @template {new (...args: any[]) => any} ObjectConstructor
 * @param {any} inputObject
 * @param {ObjectConstructor} objectType
 * @returns {InstanceType<ObjectConstructor>}
 */
export function verifyObjectInstance(inputObject, objectType) {
  if (inputObject instanceof objectType) return inputObject;
  throw new TypeError('Object instance check failed');
}