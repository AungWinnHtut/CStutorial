// C++ code
//Master
#include<SoftwareSerial.h>

SoftwareSerial Slave(2,3); //r,t
void setup()
{
  Slave.begin(9600);
  
}

void loop()
{
  Slave.write('a');
  delay(2000);
}
