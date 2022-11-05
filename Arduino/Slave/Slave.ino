#include<SoftwareSerial.h>

SoftwareSerial Slave(4,5); //Rx 3, Tx 5

// C++ code
//Arduino 2
void setup()
{
  Serial.begin(9600);
  Slave.begin(115200);
  
}

void loop()
{
  char ch;
  if(Slave.available())
  {
    ch = Slave.read();
    Serial.print(ch);
  }
  
}
