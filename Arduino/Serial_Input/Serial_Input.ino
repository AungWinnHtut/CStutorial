
char c;
void setup() {
  Serial.begin(9600);
  pinMode(13,OUTPUT);
}

void loop() {
  Serial.println("LED ON (1) or LED OFF (0)");
  while(Serial.available()<=0)
  {
    delay(200);
  }
  c = Serial.read();
  if(c=='1')
  {
    digitalWrite(13,HIGH);
  }
  if(c=='0')
  {
    digitalWrite(13,LOW);
  }
  
  
}
