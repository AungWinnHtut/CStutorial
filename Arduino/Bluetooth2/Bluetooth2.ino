#include<SoftwareSerial.h>

SoftwareSerial  bluetooth(12,11);
void setup() {
  Serial.begin(9600);
  bluetooth.begin(9600);
  pinMode(2,OUTPUT);
  pinMode(3,OUTPUT);
  pinMode(4,OUTPUT);
  pinMode(5,OUTPUT);
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
     digitalWrite(2,HIGH);
    }
    if(iData=='B')
    {
      digitalWrite(3,HIGH);
    }
    if(iData=='R')
    {
      digitalWrite(2,LOW);
    }
    if(iData=='L')
    {
      digitalWrite(3,LOW);
    }
  }

  
  //delay(100);
}
