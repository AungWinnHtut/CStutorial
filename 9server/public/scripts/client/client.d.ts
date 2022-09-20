import ConnectionHandler from './connectionHandler.mjs';

declare global {
  interface Window {
    connectionHandler: Promise<ConnectionHandler>;
    readyPromise: Promise<void>;
  }
}
