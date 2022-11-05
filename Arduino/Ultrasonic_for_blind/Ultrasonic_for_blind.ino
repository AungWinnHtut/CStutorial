#include<Wire.h>
#include<LiquidCrystal_I2C.h>


int TrigPin1 = 6;
int EchoPin1 = 3;

LiquidCrystal_I2C lcd(0x27, 16, 2);

void setup() {
  lcd.init();
  lcd.backlight();
  Serial.begin(9600);
  pinMode(7, OUTPUT);
  pinMode(TrigPin1, OUTPUT);
}

void loop() {
  int dist = 0;

  dist = funDistance(6, 3, 1);
  lcd.setCursor(0, 1);
  lcd.print("Distance =");
  lcd.print(dist);
  lcd.print(" inches");

  if (dist > 36 )
  {
    digitalWrite(7, HIGH);
    delay(100);
    digitalWrite(7, LOW);
    delay(1000);
  }
  else if (dist > 24 && dist <= 36)
  {
    digitalWrite(7, HIGH);
    delay(100);
    digitalWrite(7, LOW);
    delay(500);
  }

  else if (dist > 12 && dist <= 24)
  {
    digitalWrite(7, HIGH);
    delay(100);
    digitalWrite(7, LOW);
    delay(300);
  }
  else if (dist > 6 && dist <= 12)
  {
    digitalWrite(7, HIGH);
    delay(100);
    digitalWrite(7, LOW);
    delay(100);    
  }
   else if (dist > 1 && dist <= 6)
  {
    digitalWrite(7, HIGH);
    delay(50);
    digitalWrite(7, LOW);
    delay(50);    
  }
  
}

int funDistance(int TrigPin, int EchoPin, int Unit) {
  long duration;
  int distanceCm;
  int distanceInch;

  digitalWrite(TrigPin, LOW);
  delayMicroseconds(2);
  digitalWrite(TrigPin, HIGH);
  delayMicroseconds(10);
  digitalWrite(TrigPin, LOW);


  duration = pulseIn(EchoPin, HIGH);
  distanceCm = duration * 0.034 / 2;
  distanceInch = duration * 0.0133 / 2;
  Serial.println(duration);
  lcd.setCursor(0, 0);
  lcd.print("Duration =");
  lcd.print(duration);
  lcd.print(" milisec");

  switch (Unit)
  {
    case 0: return distanceCm; break;
    case 1: return distanceInch; break;
    default: return -1;
  }
}
