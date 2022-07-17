#include<SoftwareSerial.h>

SoftwareSerial  bluetooth(12,11);
void setup() {
  Serial.begin(9600);
  bluetooth.begin(9600);
  delay(1000);
}

void loop() {  
  for(int i=33;i<127;i++)
  {
    i=255;
    Serial.print("Printing..");
    Serial.print(i,DEC);
    Serial.print("-");
    Serial.print(i,BIN);
    Serial.print("-");
    Serial.println(char(i));
    for(int j=0;j<5000000;j++)
    {    
      bluetooth.print(char(i)); 
      delay(60);
    }
    delay(1000); 
  }
  
}
