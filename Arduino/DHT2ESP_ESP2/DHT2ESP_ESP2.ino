#include <Arduino.h>

#include <ESP8266WiFi.h>
#include <ESP8266WiFiMulti.h>

#include <WebSocketsClient.h>

#include <Hash.h>

#define SSID "GreenHackers"
#define Password "1234567890a"

#define DeviceAPIWebsocketIP "192.168.0.102"
#define DeviceAPIWebsocketPort 80

#define Token "token"

#define USE_SERIAL Serial

ESP8266WiFiMulti WiFiMulti;
WebSocketsClient webSocket;

int webflag = 0;


void setup() {
  USE_SERIAL.begin(115200);
  delay(500);
  USE_SERIAL.println("Booted..");
  for(uint8_t t = 4; t > 0; t--) delay(1000);

  WiFiMulti.addAP(SSID, Password);
  while(WiFiMulti.run() != WL_CONNECTED) delay(100);
  USE_SERIAL.println("Wifi Connected");
  webSocket.begin(DeviceAPIWebsocketIP, DeviceAPIWebsocketPort, "/connectdevice");
  webSocket.onEvent(webSocketEvent);
  webSocket.setReconnectInterval(5000);
  
  // start heartbeat (optional)
  // ping server every 15000 ms
  // expect pong from server within 3000 ms
  // consider connection disconnected if pong is not received 2 times
  webSocket.enableHeartbeat(15000, 3000, 2);
}

void loop() {
  webSocket.loop();
  sendData();
}

size_t dataLeft = 0;

void sendData() {
  //if websocket is not connected, exit immediately
  if (webflag==0) { return; }
  //else connected!
  
    USE_SERIAL.print('Websocket connected');
  
  
  
  while (USE_SERIAL.available() == 0) { }

  if (dataLeft == 0) dataLeft = Serial.read();

  if (USE_SERIAL.available() == dataLeft) {
    const char* pBuffer = new char[dataLeft + 1] { '\0' };
    Serial.readBytes((uint8_t*)pBuffer, dataLeft);
    webSocket.sendBIN((uint8_t*)pBuffer, dataLeft);
  }
}

void webSocketEvent(WStype_t type, uint8_t* payload, size_t length) {
  switch(type) {
    case WStype_DISCONNECTED:
       webflag = 0;
      break;
    case WStype_CONNECTED:
      webflag = 1;
      break;
    case WStype_BIN:
      hexdump(payload, length);

      // send data to server
      // webSocket.sendBIN(payload, length);
      break;
    }
}
