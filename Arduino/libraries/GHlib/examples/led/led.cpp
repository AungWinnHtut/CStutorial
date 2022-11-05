#include<Arduino.h>


void funBlink(int pin,int delaytime)
{
  digitalWrite(pin, HIGH);
  delay(delaytime); // Wait for 1000 millisecond(s)
  digitalWrite(pin, LOW);
  delay(delaytime); // Wait for 1000 millisecond(s)
}