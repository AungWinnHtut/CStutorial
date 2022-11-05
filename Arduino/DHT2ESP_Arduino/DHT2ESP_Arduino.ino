// Example testing sketch for various DHT humidity/temperature sensors
// Written by ladyada, public domain

// REQUIRES the following Arduino libraries:
// - DHT Sensor Library: https://github.com/adafruit/DHT-sensor-library
// - Adafruit Unified Sensor Lib: https://github.com/adafruit/Adafruit_Sensor

#include "SoftwareSerial.h"
#include "DHT.h"

#define DHTPIN 11     // Digital pin connected to the DHT sensor
// Feather HUZZAH ESP8266 note: use pins 3, 4, 5, 12, 13 or 14 --
// Pin 15 can work but DHT must be disconnected during program upload.

// Uncomment whatever type you're using!
#define DHTTYPE DHT11   // DHT 11
//#define DHTTYPE DHT22   // DHT 22  (AM2302), AM2321
//#define DHTTYPE DHT21   // DHT 21 (AM2301)

#define ESP_RX 2
#define ESP_TX 3
// Connect pin 1 (on the left) of the sensor to +5V
// NOTE: If using a board with 3.3V logic like an Arduino Due connect pin 1
// to 3.3V instead of 5V!
// Connect pin 2 of the sensor to whatever your DHTPIN is
// Connect pin 3 (on the right) of the sensor to GROUND (if your sensor has 3 pins)
// Connect pin 4 (on the right) of the sensor to GROUND and leave the pin 3 EMPTY (if your sensor has 4 pins)
// Connect a 10K resistor from pin 2 (data) to pin 1 (power) of the sensor

// Initialize DHT sensor.
// Note that older versions of this library took an optional third parameter to
// tweak the timings for faster processors.  This parameter is no longer needed
// as the current DHT reading algorithm adjusts itself to work on faster procs.
DHT dht(DHTPIN, DHTTYPE);
SoftwareSerial ESP(ESP_RX, ESP_TX);
#define Token "token"

void setup() {
  Serial.begin(9600);
  Serial.println(F("DHTxx test!"));

  ESP.begin(115200);
  
  dht.begin();

  while (ESP.available() == 0) { }
  if(ESP.read()=='*')
  {
    Serial.println("******");
  }
  
  const String token = String(Token);
  char* message = new char[5 + token.length()] { 4 + token.length(), 0, 0, 0, 0 };
  ESP.write(message, 5 + token.length());

  delete [] message;
}

void loop() {
  // Wait a few seconds between measurements.
  delay(2000);

  // Reading temperature or humidity takes about 250 milliseconds!
  // Sensor readings may also be up to 2 seconds 'old' (its a very slow sensor)
  float h = dht.readHumidity();
  // Read temperature as Celsius (the default)
  float t = dht.readTemperature();
  // Read temperature as Fahrenheit (isFahrenheit = true)
  float f = dht.readTemperature(true);

  // Check if any reads failed and exit early (to try again).
  if (isnan(h) || isnan(t) || isnan(f)) {
    Serial.println(F("Failed to read from DHT sensor!"));
    return;
  }

  // Compute heat index in Fahrenheit (the default)
  float hif = dht.computeHeatIndex(f, h);
  // Compute heat index in Celsius (isFahreheit = false)
  float hic = dht.computeHeatIndex(t, h, false);  


  while (ESP.available() == 0 || ESP.peek() != '*') { }
  const String humidityID = String("6306024fd2a6f70702fe46c8");
  char humidityMessage[51] = { 50, 0, 0, 0, 2, 24 };

  strcat(&humidityMessage[6], humidityID.c_str());
  strcat(&humidityMessage[30], String(h).c_str());
  ESP.write(humidityMessage, 51);

  while (ESP.available() == 0 || ESP.peek() != '*') { }
  const String tempID = String("63060250d2a6f70702fe46c9");
  char tempMessage[51] = { 50, 0, 0, 0, 2, 24 };

  strcat(&tempMessage[6], tempID.c_str());
  strcat(&tempMessage[30], String(t).c_str());
  ESP.write(tempMessage, 51);
/*
  Serial.print(F("Humidity: "));
  Serial.print(h);
  Serial.print(F("%  Temperature: "));
  Serial.print(t);
  Serial.print(F("°C "));
  Serial.print(f);
  Serial.print(F("°F  Heat index: "));
  Serial.print(hic);
  Serial.print(F("°C "));
  Serial.print(hif);
  Serial.println(F("°F"));*/
}
