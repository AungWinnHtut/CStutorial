void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
}

void loop() {
  Serial.print("compiled: ");
  Serial.print(__DATE__);
  Serial.println(__TIME__);


}
