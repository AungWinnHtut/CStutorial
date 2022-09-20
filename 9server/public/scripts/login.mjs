/// <reference lib="dom" />
'use strict';

import { verifyObjectInstance } from "./utils.mjs";

const [loginForm, nameInput, passInput, submitButton, spin, loginFail] = [
  verifyObjectInstance(document.getElementById('loginForm'), HTMLFormElement),
  verifyObjectInstance(document.getElementById('nameInput'), HTMLInputElement),
  verifyObjectInstance(document.getElementById('passwordInput'), HTMLInputElement),
  verifyObjectInstance(document.getElementById('submitButton'), HTMLInputElement),
  verifyObjectInstance(document.getElementById('spin'), HTMLElement),
  verifyObjectInstance(document.getElementById('loginFail'), HTMLElement),
];

/**
 * @param {boolean} success
 * @param {Response} data
 */
async function handleResponse(success, data) {
  if (!success || data.status >= 400) {
    nameInput.disabled =
      passInput.disabled =
      submitButton.disabled =
      !(spin.hidden =
        !!(loginFail.style.opacity = '1'));
    return nameInput.select();
  }

  loginFail.style.opacity = '0';
  const token = await data.text()

  localStorage.setItem('token', token);
  window.dispatchEvent(new CustomEvent('authenticated', { detail: token }));
  if (!Reflect.get(window, 'disableAuthRedirect'))
    window.location.assign('/');
}

loginForm.addEventListener('submit', e => {
  e.preventDefault();
  nameInput.disabled =
    passInput.disabled =
    submitButton.disabled =
    !(spin.hidden = false);

  fetch('/api/auth/login', {
    body: JSON.stringify({
      username: nameInput.value,
      password: passInput.value,
    }),
    headers: new Headers({ 'Content-Type': 'text/json' }),
    method: 'POST',
  }).then(
    async data => await handleResponse(true, data),
    async e => await handleResponse(false, e)
  );
});