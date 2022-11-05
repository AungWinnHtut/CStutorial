int orange = 2;
int blue = 5;
int red = 8;
void setup()
{
  pinMode(orange, OUTPUT);
  pinMode(blue, OUTPUT);
  pinMode(red, OUTPUT);
  Serial.begin(9600);
}

void loop()
{
  Serial.println("Which LED want to ON");
  while(Serial.available() <=0 )
  {
    Serial.print(".");
    delay(100); //waiting
  }
  //Serial.println(Serial.available());
  
  char command = Serial.read();
  
  
  if(command=='r')
  {
    digitalWrite(red,HIGH);
  }
  if(command=='b')
  {
    digitalWrite(blue,HIGH);
  }
  if(command=='o')
  {
    digitalWrite(orange,HIGH);
  }
  if(command=='1')
  {
    digitalWrite(red,LOW);
  }
  if(command=='2')
  {
    digitalWrite(blue,LOW);
  }
  if(command=='3')
  {
    digitalWrite(orange,LOW);
  }
  
}
