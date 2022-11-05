/*
  ESP8266 Blink by Simon Peter
  Blink the blue LED on the ESP-01 module
  This example code is in the public domain

  The blue LED on the ESP-01 module is connected to GPIO1
  (which is also the TXD pin; so we cannot use Serial.print() at the same time)

  Note that this sketch uses LED_BUILTIN to find the pin with the internal LED
*/

void setup() {
  pinMode(2, OUTPUT);     // Initialize the LED_BUILTIN pin as an output
  Serial.begin(9600);
}

// the loop function runs over and over again forever
void loop() {
  digitalWrite(2, LOW);   // Turn the LED on (Note that LOW is the voltage level
  Serial.println("LED OFF");
  // but actually the LED is on; this is because
  // it is active low on the ESP-01)
  delay(1000);                      // Wait for a second
  digitalWrite(2, HIGH);  // Turn the LED off by making the voltage HIGH
  Serial.println("LED ON");
  delay(1000);                      // Wait for two seconds (to demonstrate the active low LED)
}
