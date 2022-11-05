int const buzzerPin = 7;
void setup() {
  // put your setup code here, to run once:
}

void loop() {
  for (int count = 0; count < 3; count++) {
    for (int i = 200; i <= 800; i++) {
      tone(buzzerPin, i);
      delay(5);
    }
    noTone(buzzerPin);
    delay(3000);
    for (int i = 800; i >= 200; i--) {
      tone(buzzerPin, i);
      delay(5);
    }
    noTone(buzzerPin);
    delay(3000);
    
  }
  while(1){
    digitalWrite(buzzerPin,LOW);
  }
}