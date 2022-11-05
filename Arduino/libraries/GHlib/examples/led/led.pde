#include "led.h"
void setup()
{
  pinMode(6, OUTPUT);
}

void loop()
{
  funBlink(6,1000);
}

