#include<Servo.h>
Servo servo1;
Servo servo2;
void setup() {
  servo1.attach(D4);
  servo1.attach(D6);
  
}

void loop() {
  // put your main code here, to run repeatedly:
  servo1.write(90);
  servo2.write(90);
  delay(1000);
  servo1.write(180);
  servo2.write(180);
  delay(1000);
}
