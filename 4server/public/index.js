/// <reference lib="dom" />
'use strict';

const [loginScreen, nameInput, passInput, submitButton, spin] = [
  document.getElementById('login'),
  document.getElementById('nameInput'),
  document.getElementById('passwordInput'),
  document.getElementById('submitButton'),
  document.getElementById('spin'),
];

if (!(
  loginScreen &&
  nameInput instanceof HTMLInputElement &&
  passInput instanceof HTMLInputElement &&
  submitButton instanceof HTMLInputElement &&
  spin
)) throw '';
if (localStorage.getItem('token')) {
  document.body.removeChild(loginScreen);
  const client = document.getElementById('client');
  if (client) client.hidden = false;
}

submitButton.addEventListener('click', e => {
  e.preventDefault();
  //nameInput.disabled =
  //  passInput.disabled =
  //  submitButton.disabled = true;
  //
  //spin.hidden = false;

  fetch('api/auth/login', {
    body: JSON.stringify({
      username: nameInput.value,
      password: passInput.value,
    }),
    headers: new Headers({ 'Content-Type': 'text/json' }),
    method: 'POST',
  }).then(async data => {
    if (data.status !== 200) return;
    localStorage.setItem('token', await data.text());
    loginScreen?.classList.add('loggedIn');
    const client = document.getElementById('client');
    if (client) client.hidden = false;
  })
});

fetch('/api/getDataCollections').then(async res => {
  const data = await res.json();

  const humidity = data['6306024fd2a6f70702fe46c8'];
  const temp = data['63060250d2a6f70702fe46c9'];
  const soil = data['6306026fd2a6f70702fe46c7'];

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

  let sxValues = soil.map(t => t[0]);
  let syValues = soil.map(t => t[1]);

  new Chart("soil", {
    type: "line",
    data: {
      labels: sxValues,
      datasets: [{
        label: 'Soil Moisture',
        backgroundColor: "rgb(255,205,0)",
        borderColor: "rgb(255,128,0)",
        data: syValues
      }]
    },
    options: {}
  });


})