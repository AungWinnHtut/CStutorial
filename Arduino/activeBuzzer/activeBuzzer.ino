int const buzzerPin = 2;
void setup() {
  pinMode(A0, INPUT);
  pinMode(buzzerPin, OUTPUT);
  Serial.begin(9600);
}

void loop() {
  int input = analogRead(A0);
  Serial.println(input);
  if (input > 500) {
    digitalWrite(buzzerPin, HIGH);
  } else {

    digitalWrite(buzzerPin, LOW);
  }
}