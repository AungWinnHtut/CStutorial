    /////////////////////////////////////////////////////////////////
   //            Arduino Weather Station Project #2     v1.01     //
  //         Get the latest version of the code here:            //
 //     http://educ8s.tv/arduino-button-debounce-tutorial       //
/////////////////////////////////////////////////////////////////

const int buttonPin = 13;    
const int ledPin =  2;     
int ledState = LOW;
boolean buttonState = LOW; 

int pressed=0;

void setup() {
  pinMode(ledPin, OUTPUT);
  pinMode(buttonPin, INPUT);
}

void loop() {
  
  if(debounceButton(buttonState) == HIGH && buttonState == LOW) //if button is pressed and last button state is unpressed
  {
    pressed++;
    buttonState = HIGH;
  }
  else if(debounceButton(buttonState) == LOW && buttonState == HIGH) //if button is unpressed and last button state is pressed
  {
       buttonState = LOW;
  }
  if(pressed == 10)
  {
    digitalWrite(ledPin,HIGH);
  }
}
boolean debounceButton(boolean state)
{
  boolean stateNow = digitalRead(buttonPin);
  if(state!=stateNow)
  {
    delay(10);
    stateNow = digitalRead(buttonPin);
  }
  return stateNow;
}

  


