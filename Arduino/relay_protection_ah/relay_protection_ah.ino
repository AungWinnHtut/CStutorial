
//for active high devices
String cmd;
void setup() {
  // initialize digital pin LED_BUILTIN as an output.
  pinMode(LED_BUILTIN, OUTPUT);
  pinMode(2, OUTPUT);     //VCC pin-2
  delay(1000);
  digitalWrite(2,HIGH);   //VCC power on here
  Serial.begin(9600);
  digitalWrite(13,LOW);  //Relay is OFF initially (Active LOW);
  
  
}

// the loop function runs over and over again forever
void loop() {
  Serial.write("Enter Command, 1 for ON, 0 for OFF : ");
  while(Serial.available()<=0)
  {
    //waiting here
    delay(10);
  }
  
  cmd = Serial.readString();
  Serial.println(cmd);
  
  if(cmd=="1")
  {
    digitalWrite(13,HIGH);
  }
  
  if(cmd=="0")
  {
    digitalWrite(13,LOW);
  }
  
 
}
