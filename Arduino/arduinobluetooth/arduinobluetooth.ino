#include <SoftwareSerial.h>
SoftwareSerial BT(9,8); //TXD, RXD

void setup() {
  Serial.begin(9600);
  BT.begin(9600);

}

void loop() {
  
  while(BT.available()==0)
  {
    ;
  }

  char cmd = BT.read();
  Serial.println(cmd);

  if(cmd=='S')
  {
    Serial.println("Stop the Car");
  }
  if(cmd=='L')
  {
    Serial.println("Moving Left");
  }
  if(cmd=='R')
  {
    Serial.println("Moving Right");
  }
}
