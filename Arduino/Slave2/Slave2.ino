/*
  Software serial multple serial test

 Receives from the hardware serial, sends to software serial.
 Receives from software serial, sends to hardware serial.

 The circuit:
 * RX is digital pin 10 (connect to TX of other device)
 * TX is digital pin 11 (connect to RX of other device)

 Note:
 Not all pins on the Mega and Mega 2560 support change interrupts,
 so only the following can be used for RX:
 10, 11, 12, 13, 50, 51, 52, 53, 62, 63, 64, 65, 66, 67, 68, 69

 Not all pins on the Leonardo and Micro support change interrupts,
 so only the following can be used for RX:
 8, 9, 10, 11, 14 (MISO), 15 (SCK), 16 (MOSI).

 created back in the mists of time
 modified 25 May 2012
 by Tom Igoe
 based on Mikal Hart's example

 This example code is in the public domain.

 */
#include <SoftwareSerial.h>

SoftwareSerial mySerial(2, 3); // RX, TX

void setup() {
  // Open serial communications and wait for port to open:
  Serial.begin(9600);
  while (!Serial) {
    ; // wait for serial port to connect. Needed for native USB port only
  }


  Serial.println("I am Slave!");

  // set the data rate for the SoftwareSerial port
  mySerial.begin(9600);
  mySerial.println("I am Slave!");
  pinMode(13,OUTPUT);
}

void loop() { // run over and over
  if (mySerial.available()) {
    char cmd = mySerial.read();
    Serial.write(cmd);
    if(cmd=='o')
    {
      digitalWrite(13,HIGH);
      Serial.println("LED ON");
    }
    if(cmd=='c')
    {
      digitalWrite(13,LOW);
      Serial.println("LED OFF");
    }
  }
  if (Serial.available()) {
    mySerial.write(Serial.read());
  }
}
