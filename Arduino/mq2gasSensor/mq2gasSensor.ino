void setup() {
 pinMode(A0,INPUT);
 pinMode(2,INPUT);
 Serial.begin(9600);
 Serial.println("Initializing the sensor!");
 delay(10000);
}

void loop() {
  int gas = analogRead(A0);
  int status = digitalRead(2);
  Serial.print("Status : "); Serial.println(status);
  Serial.print("Gas Value : "); Serial.println(gas);
  delay(1000);

}
