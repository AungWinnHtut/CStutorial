#include<SoftwareSerial.h>
// C++ code
//Arduino 1

SoftwareSerial Master(3,4); //Rx 3,Tx 4

void setup()
{
  Serial.begin(9600);
  Master.begin(115200);
  
}

void loop()
{
  Master.write("M");
  delay(2000);
  
}
