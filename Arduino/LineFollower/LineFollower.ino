const int sensor_pin =2;
const int buzzer_pin =7;

void setup() {

  pinMode(sensor_pin,INPUT);
  pinMode(buzzer_pin,OUTPUT);
  Serial.begin(9600);

}

void loop() {
  
  int detector = digitalRead(sensor_pin);

  
  if(detector==0)
  {
    Serial.println("White Detected");
    digitalWrite(buzzer_pin,HIGH);
  }
  else
  {
    Serial.println("Black Detected");
    digitalWrite(buzzer_pin,LOW);
  }

  
  
}

