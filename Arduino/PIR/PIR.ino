// C++ code
//
void setup()
{
  pinMode(2, INPUT);
  pinMode(3, OUTPUT);
  Serial.begin(9600);
}

void loop()
{
  int pir = digitalRead(2);
  Serial.println(pir);
  if(pir)
  {
    digitalWrite(3,HIGH);
  }
  else
  {
    digitalWrite(3,LOW);
  }
}