// DHT Temperature & Humidity Sensor
// Unified Sensor Library Example
// Written by Tony DiCola for Adafruit Industries
// Released under an MIT license.

// REQUIRES the following Arduino libraries:
// - DHT Sensor Library: https://github.com/adafruit/DHT-sensor-library
// - Adafruit Unified Sensor Lib: https://github.com/adafruit/Adafruit_Sensor

#include <Adafruit_Sensor.h>
#include <DHT.h>
#include <DHT_U.h>

#define DHTPIN 2     // Digital pin connected to the DHT sensor 
#define DHTTYPE    DHT11     // DHT 11



// See guide for details on sensor wiring and usage:
//   https://learn.adafruit.com/dht/overview

DHT_Unified dht(DHTPIN, DHTTYPE);

uint32_t delayMS;

void setup() {
  Serial.begin(9600);
  // Initialize device.
  dht.begin();
  Serial.println(F("DHTxx Unified Sensor Example"));
  // Print temperature sensor details.
  sensor_t sensor;
  dht.temperature().getSensor(&sensor);
  Serial.println("------------------------------------");
  Serial.println("Temperature Sensor");
  Serial.print  ("Sensor Type: "); Serial.println(sensor.name);
  Serial.print  ("Driver Ver:  "); Serial.println(sensor.version);
  Serial.print  ("Unique ID:   "); Serial.println(sensor.sensor_id);
  Serial.print  ("Max Value:   "); Serial.print(sensor.max_value); Serial.println("°C");
  Serial.print  ("Min Value:   "); Serial.print(sensor.min_value); Serial.println("°C");
  Serial.print  ("Resolution:  "); Serial.print(sensor.resolution); Serial.println("°C");
  Serial.println(F("------------------------------------"));
  // Print humidity sensor details.
  dht.humidity().getSensor(&sensor);
  Serial.println("Humidity Sensor");
  Serial.print  ("Sensor Type: "); Serial.println(sensor.name);
  Serial.print  ("Driver Ver:  "); Serial.println(sensor.version);
  Serial.print  ("Unique ID:   "); Serial.println(sensor.sensor_id);
  Serial.print  ("Max Value:   "); Serial.print(sensor.max_value); Serial.println("%");
  Serial.print  ("Min Value:   "); Serial.print(sensor.min_value); Serial.println("%");
  Serial.print  ("Resolution:  "); Serial.print(sensor.resolution); Serial.println("%");
  Serial.println("------------------------------------");
  // Set delay between sensor readings based on sensor details.
  delayMS = sensor.min_delay / 1000;
}

void loop() {
  // Delay between measurements.
  delay(delayMS);
  // Get temperature event and print its value.
  sensors_event_t event;
  dht.temperature().getEvent(&event);
  if (isnan(event.temperature)) {
    Serial.println("Error reading temperature!");
  }
  else {
    Serial.print("Temperature: ");
    Serial.print(event.temperature);
    Serial.println("°C");
  }
  // Get humidity event and print its value.
  dht.humidity().getEvent(&event);
  if (isnan(event.relative_humidity)) {
    Serial.println("Error reading humidity!");
  }
  else {
    Serial.print("Humidity: ");
    Serial.print(event.relative_humidity);
    Serial.println("%");
  }
}
