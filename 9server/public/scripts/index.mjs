/// <reference lib="dom" />
'use strict';

import { verifyObjectInstance } from "./utils.mjs";

const [headerAnimation] = [
  verifyObjectInstance(document.getElementById('headerAnimation'), HTMLElement)
];

const clientFrame = /** @type {Promise<HTMLIFrameElement>} */
  (new Promise(resolve => {
    document.body.insertBefore(
      Object.assign(document.createElement('iframe'), {
        /** @this {HTMLIFrameElement} */
        onload() {
          if (this.contentWindow === null) throw 'Client window is null';
          resolve(this)
        },
        id: 'clientFrame',
        src: 'pages/client.html',
        hidden: true
      }),
      document.body.firstChild
    )
  })).then(clientFrame => {
    clientFrame.contentWindow?.addEventListener('reload', () =>
      window.location.reload()
    );
    return clientFrame;
  });

function prepareLogin() {
  clientFrame.then(clientFrame => {
    const header = clientFrame.contentWindow?.document.querySelector('#header>h1');
    if (!header) throw 'Header not found';
      /** @type {HTMLElement} */ (header).style.opacity = '0';
  });

  document.body.insertBefore(Object.assign(document.createElement('iframe'), {
    /** @this {HTMLIFrameElement} */
    onload() {
      if (!this.contentWindow) return;
      Reflect.set(this.contentWindow, 'disableAuthRedirect', true);
      this.contentWindow.addEventListener('authenticated', async e => {
        console.log('sending auth to client');
        (await clientFrame).contentWindow?.dispatchEvent(new CustomEvent(e.type, { detail: Reflect.get(e, 'detail') }));
        (await clientFrame).hidden = false;
        headerAnimation.hidden = false;

        const header = this.contentWindow?.document.getElementsByTagName('header').item(0);
        if (header) header.style.opacity = '0';

        this.animate([{ opacity: '0' }], { duration: 250, iterations: 1, })
          .addEventListener('finish', () => document.body.removeChild(this));
      })
    },
    id: 'loginFrame',
    src: 'pages/login.html'
  }), document.body.lastChild);
}

if (!localStorage.getItem('token')) prepareLogin();
else {
  (async () => {
    const res = await fetch('api/auth/verifyToken', {
      body: localStorage.getItem('token'),
      headers: new Headers({ 'Content-Type': 'text/jwt' }),
      method: 'POST',
    });

    if (res.status < 400) {
      (await clientFrame).hidden = false;
      console.log('sending auth to client');
      return (await clientFrame).contentWindow?.dispatchEvent(new CustomEvent('authenticated', { detail: localStorage.getItem('token') }));
    }
    localStorage.removeItem('token');
    return prepareLogin();
  })();
}