// C++ code
//Slave
#include<SoftwareSerial.h>
SoftwareSerial Master(2,3); //rt
void setup()
{
  pinMode(13, OUTPUT);
  Master.begin(9600);
  Serial.begin(9600);
}

void loop()
{
  while(Master.available()==0)
  {}
  char ch = Master.read();
  Serial.println(ch);
}
