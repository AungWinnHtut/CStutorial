/// <reference path="client.d.ts" />
'use strict';

import { verifyObjectInstance } from "../utils.mjs";

const UI = {
  deviceInfoContainer: verifyObjectInstance(document.getElementById('deviceInfoContainer'), HTMLElement),
  deviceList: verifyObjectInstance(document.getElementById('deviceList'), HTMLElement),
  newDeviceForm: verifyObjectInstance(document.getElementById('addDevice'), HTMLFormElement),
  newDeviceName: verifyObjectInstance(document.querySelector('#addDevice>input[name="deviceName"]'), HTMLInputElement),
};

import { Command } from "./connectionHandler.mjs";

/**
 * @typedef {{
 *   id: string,
 *   creationTimestamp: Date,
 *   name?: string,
 *   permissions: string[],
 *   isActive?: boolean
 * }} Device
 */

export default class DeviceManager {
  static UI = UI;

  /** @type {{ [key: string]: Device}} */
  static #devices = {};
  static get devices() { return DeviceManager.#devices };
  static set devices(value) { (DeviceManager.#devices = value) && DeviceManager.#updateList() };

  /**
   * @param {Device} device
   */
  static createDeviceListItem(device) {
    const deviceDiv = Object.assign(document.createElement('div'), /** @type {Partial<HTMLDivElement>} */({
      onclick() {
        DeviceManager.showDevice(device);
      }
    }));
    console.log(device.name)
    deviceDiv.append(
      Object.assign(document.createElement('div'), { innerHTML: !device.name || device.name === '' ? device.id : device.name }),
      Object.assign(document.createElement('div'), { innerHTML: device.isActive === null ? '⚪' : device.isActive ? '🟢' : '🔴' }),
    );
    return deviceDiv;
  }

  /** @param {Device} device */
  static showDevice(device) {
    const deviceInfo = Object.assign(document.createElement('div'), /** @type {Partial<HTMLDivElement>} */({
      id: 'deviceInfo'
    }))

    const deviceInfoHeader = document.createElement('header');

    const deviceImage = Object.assign(document.createElement('img'), /** @type {Partial<HTMLImageElement>} */({
      src: '/assets/ic_fluent_developer_board_24_regular.svg'
    }));

    const deviceHeaderInfoContainer = document.createElement('div');
    deviceHeaderInfoContainer.append(
      Object.assign(document.createElement('p'), /** @type {Partial<HTMLParagraphElement>} */({
        innerText: device.id
      })),
      Object.assign(document.createElement('h1'), /** @type {Partial<HTMLHeadingElement>} */({
        innerText: !device.name || device.name === '' ? 'Unnamed Device' : device.name
      })),
      Object.assign(document.createElement('button'), /** @type {Partial<HTMLButtonElement>} */({
        innerText: 'Generate Token'
      }), {
        /** @this {HTMLButtonElement} */
        async onclick() {
          // TODO: loadiing icon
          this.innerHTML = 'Requesting Token...';
          this.disabled = true;

          (await window.connectionHandler).sendCommand(new Command('graphql', `
              mutation generateToken {
                device {
                  token: generateToken(id: "${device.id}")
                }
              }
            `
          )).then(response => {
            this.disabled = false;
            console.log(response);
            if (response.context !== 'data') {
              this.innerHTML = 'Error'
              throw response;
            }
            navigator.clipboard.writeText(response.payload?.['data']?.['device']?.['token'] ?? 'null');
            this.innerHTML = "Copied to clipboad";
          });
        }
      }),
    );

    deviceInfoHeader.append(deviceImage, deviceHeaderInfoContainer);
    deviceInfo.appendChild(deviceInfoHeader)
    UI.deviceInfoContainer.replaceChildren(deviceInfo)
  }

  static #updateList() {
    DeviceManager.UI.deviceList.querySelectorAll(':scope>div').forEach(div => DeviceManager.UI.deviceList.removeChild(div))
    for (const deviceId in DeviceManager.#devices) {
      const device = DeviceManager.#devices[deviceId];
      if (device === undefined) return;

      DeviceManager.UI.deviceList.insertBefore(
        DeviceManager.createDeviceListItem(device),
        DeviceManager.UI.deviceList.lastElementChild
      );
    }
  }

  static updateList() {
    DeviceManager.#updateList();
  }

  static {
    DeviceManager.UI.newDeviceForm.addEventListener('submit', async e => {
      e.preventDefault();
      (await window.connectionHandler).sendCommand(new Command('graphql', `
            mutation addDevice {
              device {
                create(name: "${DeviceManager.UI.newDeviceName?.value}") { id, name, isActive }
              }
            }
          `
      )).then(response => {
        if (response.context !== 'data') throw response;
        /** @type {Device} */
        const device = response.payload.data.device.create;
        // TODO: this is very inefficient
        DeviceManager.devices[device.id] = device;
        DeviceManager.updateList();
      });
      DeviceManager.UI.newDeviceName.value = '';
    });

    window.connectionHandler.then(connectionHandler => {
      connectionHandler.sendCommand(new Command('graphql', 'query getDevices { devices { name, id, isActive } }'))
        .then(response => {
          if (
            response.context !== 'data' ||
            !response.payload?.['data']?.['devices']
          ) throw response;

          DeviceManager.devices = Object.assign({},
            .../** @type {Device[]} */
            (response.payload.data.devices).map((device) => ({
              [device.id]: device
            }))
          );
        });
    })
  }
};