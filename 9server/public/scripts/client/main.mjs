/// <reference lib="dom" />
/// <reference path="client.d.ts" />
/// <reference path="modules.d.ts" />
'use strict';

/** @type {(value: ConnectionHandler) => void} */
let connectionHandlerResolve;
window.connectionHandler = /** @type {Promise<ConnectionHandler>} */
  (new Promise(resolve => connectionHandlerResolve = resolve));

import { Chart, registerables } from 'https://cdn.jsdelivr.net/npm/chart.js@3.9.1/dist/chart.mjs';
Chart.register(...registerables);

import ConnectionHandler from './connectionHandler.mjs';
/** @typedef {import('./deviceManager.mjs').Device} Device */

const WebClientWsUrl = 'ws://127.0.0.1:3000/connectwebclient';

const [tabButtons, tabs, dashboardTab, dataTab, statesTab, devicesTab, deviceList, addDeviceName, addDeviceForm, usersTab] = [
  document.querySelectorAll('input[name="tabButton"]'),
  document.querySelectorAll('#tabs > *'),
  document.getElementById('dashboardTab'),
  document.getElementById('dataTab'),
  document.getElementById('statesTab'),
  document.getElementById('devicesTab'),
  document.getElementById('deviceList'),
  document.querySelector('#addDevice>input[name="deviceName"]'),
  document.getElementById('addDevice'),
  document.getElementById('usersTab'),
];

if (!(
  dashboardTab instanceof HTMLElement &&
  dataTab instanceof HTMLElement &&
  statesTab instanceof HTMLElement &&
  devicesTab instanceof HTMLElement &&
  deviceList instanceof HTMLElement &&
  addDeviceName instanceof HTMLInputElement &&
  addDeviceForm instanceof HTMLFormElement &&
  usersTab instanceof HTMLElement
)) throw 'HTML Elements check failed';

tabButtons.forEach((tabButton, i) => {
  /** @type {HTMLElement} */
  (tabButton).addEventListener('click', () => {
    tabs.forEach(tab =>
      (/** @type {HTMLElement} */(tab).style.zIndex = '0') &&
      (/** @type {HTMLElement} */(tab).style.opacity = '0')
    );
      /** @type {HTMLElement} */(tabs.item(i)).style.zIndex = '1';
      /** @type {HTMLElement} */(tabs.item(i)).style.opacity = '1';
  })
});

/** @typedef {{ type: string, message: string, packet: string }} ErrorPayload */

console.log('client waiting for auth');
window.addEventListener('authenticated', async e => {
  console.log('client authed');

  await import('./deviceManager.mjs');
  const connectionHandler = new ConnectionHandler(WebClientWsUrl, Reflect.get(e, 'detail'));
  if (await connectionHandler.authenticationResult === false) {
    localStorage.removeItem('token');
    return window.dispatchEvent(new CustomEvent('reload'));
  }

  connectionHandlerResolve(connectionHandler);



  fetch('/api/getStates').then(async res => {
    /** 
      * @type {{
      *   [key: string]: {
      *     name: string,
      *     states: string[],
      *     state: number | null
      *   }
      * }}
      */
    const data = await res.json();
    for (const /** @type {keyof data}*/ stateID in data) {
      const state = data[stateID];
      if (!state) throw 'State not found';

      statesTab.appendChild(
        Object.assign(
          document.createElement('div'),
          { className: 'stateSelect' }
        )
      ).append(
        Object.assign(
          document.createElement('h1'),
          { innerHTML: state.name }
        ),
        ...state.states.map((stateName, i) => {
          const buttonLabelElem = document.createElement('label');
          buttonLabelElem.append(
            Object.assign(
              document.createElement('input'),
              {
                type: 'radio',
                name: stateID,
                checked: state.state === i,
                async onclick() {
                  await fetch('api/setState', {
                    body: JSON.stringify({ [stateID]: i }),
                    headers: new Headers({ 'Content-Type': 'text/json' }),
                    method: 'POST',
                  });
                }
              }
            ),
            stateName
          )
          return buttonLabelElem;
        })
      );
    }
  });

  fetch('/api/getDataCollections').then(async res => {
    const data = await res.json();

    /** @type {[string, number][]} */
    const humidity = data['6306024fd2a6f70702fe46c8'];
    /** @type {[string, number][]} */
    const temp = data['63060250d2a6f70702fe46c9'];

    let hxValues = humidity.map(h => h[0]);
    let hyValues = humidity.map(h => h[1]);

    new Chart("humidity", {
      type: "line",
      data: {
        labels: hxValues,
        datasets: [{
          label: 'Humidity',
          backgroundColor: "rgb(200,200,200)",
          borderColor: "rgb(0,0,0)",
          data: hyValues
        }]
      },
      options: {}
    });

    let txValues = temp.map(t => t[0]);
    let tyValues = temp.map(t => t[1]);

    new Chart("temp", {
      type: "line",
      data: {
        labels: txValues,
        datasets: [{
          label: 'Temperature',
          backgroundColor: "rgb(255,205,0)",
          borderColor: "rgb(255,128,0)",
          data: tyValues
        }]
      },
      options: {}
    });
  })
  return;
});
