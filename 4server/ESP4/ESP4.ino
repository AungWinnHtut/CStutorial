#include <Arduino.h>
#include <Servo.h>
#include <ESP8266WiFi.h>
#include <ESP8266WiFiMulti.h>

#include <WebSocketsClient.h>

#include <Hash.h>
#include "DHT.h"

#include <Wire.h> 
#include <LiquidCrystal_I2C.h>
LiquidCrystal_I2C lcd(0x3F,20,4);

#define SSID "GreenHackers"
#define Password "1234567890a"

#define DeviceAPIWebsocketIP "192.168.0.102"
#define DeviceAPIWebsocketPort 80

#define Token "token"

#define USE_SERIAL Serial

#define DHTPIN D3 //gpio?  d1
#define DHTTYPE DHT22 

ESP8266WiFiMulti WiFiMulti;
WebSocketsClient webSocket;
DHT dht(DHTPIN, DHTTYPE);

int webflag = 0;
Servo servo1;

void setup() {
  pinMode(D5,OUTPUT);
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
  lcd.init();   
  lcd.backlight();
  lcd.setCursor(0,0);
  lcd.print("Autobot!");
  servo1.attach(D4);
  servo1.write(90);
  delay(1000);
  servo1.write(180);
  delay(1000);
  servo1.write(90);
  delay(1000);
  //digitalWrite(D5,HIGH);
}

void loop() {   
  webSocket.loop(); 
  USE_SERIAL.println("Loop again!!!!!");
  sendData(); 
}

void sendData() {
  //if websocket is not connected, exit immediately
  if(webflag==0){return ;}

  //else connected!
  const String humidityID = String("6306024fd2a6f70702fe46c8");
  const String tempID = String("63060250d2a6f70702fe46c9");
  delay(300);
  // Reading temperature or humidity takes about 250 milliseconds!
  // Sensor readings may also be up to 2 seconds 'old' (its a very slow sensor)
  float h = dht.readHumidity();
  // Read temperature as Celsius (the default)2.4
  float t = dht.readTemperature();
  // Read temperature as Fahrenheit (isFahrenheit = true)
  float f = dht.readTemperature(true);
  
  // Check if any reads failed and exit early (to try again).
  if (isnan(h) || isnan(t) || isnan(f)) {
    Serial.println(F("Failed to read from DHT sensor!"));
    return;
  }

  

  char humidityMessage[50] = { 0, 0, 0, 2, 24 };  //first byte 0 - 1 byte
                                                  //cmd id 0
                                                  //cmd context - payload 0,2
                                                  //payload 24
                                                  
  USE_SERIAL.print("humidity : ");
  USE_SERIAL.println(h);
  
  strcat(&humidityMessage[5], humidityID.c_str());
  strcat(&humidityMessage[29], String(h).c_str()); 
  webSocket.sendBIN((uint8_t*)humidityMessage, 30);
  USE_SERIAL.print("humidity bin: ");
  //USE_SERIAL.write(humidityMessage,50);
  delay(2000);
  char tempMessage[30] = { 0, 0, 0, 2, 24 };

  strcat(&tempMessage[5], tempID.c_str());
  tempMessage[29] = random(20, 30);
  webSocket.sendBIN((uint8_t*)tempMessage, 30);
  USE_SERIAL.printf("[SEND DATA] accomplished!\n");
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
