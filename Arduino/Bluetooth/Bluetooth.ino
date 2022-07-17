#include<SoftwareSerial.h>

SoftwareSerial  bluetooth(12,11);
void setup() {
  Serial.begin(9600);
  bluetooth.begin(9600);
}

void loop() {
  if(Serial.available())
  {
    int iData = Serial.read();
    //Serial.write(iData);
    Serial.println(iData,DEC);
    if(iData==97)
    {
      Serial.println("Hello World");
    }
  }

  if(bluetooth.available())
  {
    int iData = bluetooth.read();
    //Serial.write(iData);
    Serial.write(iData);
    if(iData=='F')
    {
      Serial.println("Forward");
    }
    if(iData=='B')
    {
      Serial.println("Backward");
    }
    if(iData=='R')
    {
      Serial.println("Right");
    }
    if(iData=='L')
    {
      Serial.println("Left");
    }
  }

  
  //delay(100);
}
