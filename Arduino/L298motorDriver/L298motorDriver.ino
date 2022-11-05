#include <RTClib.h>


void setup() {
  pinMode(6,OUTPUT);
  pinMode(7,OUTPUT);

  pinMode(8,OUTPUT);
  pinMode(9,OUTPUT);

}

void loop() {
  
  digitalWrite(6,HIGH);
  digitalWrite(7,LOW);
  delay(2000);
  digitalWrite(6,LOW);
  digitalWrite(7,LOW);
  delay(500);

  digitalWrite(7,HIGH);
  digitalWrite(6,LOW);
  delay(2000);
  digitalWrite(6,LOW);
  digitalWrite(7,LOW);
  delay(500);  

  digitalWrite(8,HIGH);
  digitalWrite(9,LOW);
  delay(2000);
  digitalWrite(8,LOW);
  digitalWrite(9,LOW);
  delay(500);

  digitalWrite(9,HIGH);
  digitalWrite(8,LOW);
  delay(2000);
  digitalWrite(9,LOW);
  digitalWrite(8,LOW);
  delay(500);  

  digitalWrite(6,HIGH);
  digitalWrite(7,LOW);
  digitalWrite(9,HIGH);
  digitalWrite(8,LOW);
  delay(2000);
  digitalWrite(6,LOW);
  digitalWrite(7,LOW);
  digitalWrite(9,LOW);
  digitalWrite(8,LOW);
  delay(500);  

  digitalWrite(7,HIGH);
  digitalWrite(6,LOW);
  digitalWrite(8,HIGH);
  digitalWrite(9,LOW);
  delay(2000);
  digitalWrite(6,LOW);
  digitalWrite(7,LOW);
  digitalWrite(9,LOW);
  digitalWrite(8,LOW);
  delay(500);    
}
