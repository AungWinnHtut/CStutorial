#include <Arduino.h>
#include <DHT.h>
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

#define DHTTYPE DHT11   // DHT 11
#define DHTPIN 11

ESP8266WiFiMulti WiFiMulti;
WebSocketsClient webSocket;

int webflag = 0;
DHT dht(DHTPIN, DHTTYPE);

void setup() {
  // USE_SERIAL.begin(921600);
  USE_SERIAL.begin(115200);
  dht.begin();

  //Serial.setDebugOutput(true);
  USE_SERIAL.setDebugOutput(true);

  USE_SERIAL.println();
  USE_SERIAL.println();
  USE_SERIAL.println();

  for(uint8_t t = 4; t > 0; t--) {
    USE_SERIAL.printf("[SETUP] BOOT WAIT %d...\n", t);
    USE_SERIAL.flush();
    delay(1000);
  }

  WiFiMulti.addAP(SSID, Password);
  while(WiFiMulti.run() != WL_CONNECTED) delay(100);

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
  USE_SERIAL.println("Loop again!!!!!");
  sendData(); 
}

void sendData() {
  //if websocket is not connected, exit immediately
  if(webflag==0){return ;}

  float h = dht.readHumidity();
  // Read temperature as Celsius (the default)
  float t = dht.readTemperature();

  //else connected!
  const String humidityID = String("6306024fd2a6f70702fe46c8");
  char humidityMessage[51] = { 50, 0, 0, 0, 2, 24 };

  strcat(&humidityMessage[6], humidityID.c_str());
  strcat(&humidityMessage[30], String(h).c_str());
  webSocket.sendBIN((uint8_t*)humidityMessage, 30);

  //while (ESP.available() == 0 || ESP.peek() != '*') { }
  const String tempID = String("63060250d2a6f70702fe46c9");
  char tempMessage[51] = { 50, 0, 0, 0, 2, 24 };

  strcat(&tempMessage[6], tempID.c_str());
  strcat(&tempMessage[30], String(t).c_str());
  webSocket.sendBIN((uint8_t*)tempMessage, 30);

  delay(2000);
}

void webSocketEvent(WStype_t type, uint8_t* payload, size_t length) {
  switch(type) {
    case WStype_DISCONNECTED:
      USE_SERIAL.printf("[WSc] Disconnected!\n");
       webflag = 0;
      break;
    case WStype_CONNECTED: {
      USE_SERIAL.printf("[WSc] Connected to url: %s\n", payload);
       webflag = 1;
      const String token = String(Token);
      char* message = new char[4 + token.length()] { 0, 0, 0, 0 };
      strcat(&message[4], token.c_str());

      webSocket.sendBIN((uint8_t*)message, 4 + token.length());
      delete [] message;
    }
      break;
    case WStype_TEXT:
      USE_SERIAL.printf("[WSc] get text: %s\n", payload);

      // send message to server
      // webSocket.sendTXT("message here");
      break;
    case WStype_BIN:
      USE_SERIAL.printf("[WSc] get binary length: %u\n", length);
      hexdump(payload, length);

      // send data to server
      // webSocket.sendBIN(payload, length);
      break;
        case WStype_PING:
          // pong will be send automatically
          USE_SERIAL.printf("[WSc] get ping\n");
          break;
        case WStype_PONG:
          // answer to a ping we send
          USE_SERIAL.printf("[WSc] get pong\n");
          break;
         
    }
}
