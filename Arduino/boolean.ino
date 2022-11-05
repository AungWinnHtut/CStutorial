// C++ code
//

void setup()
{
  pinMode(7,OUTPUT);
  pinMode(6,OUTPUT);
  pinMode(5,OUTPUT);
  pinMode(4,OUTPUT);
  pinMode(A0,INPUT);
  Serial.begin(9600);
 
}

void loop()
{
  int input = analogRead(A0);
  Serial.print("analog input value : ");
  Serial.println(input);
  
  //if 100% 
  //all led on
  if(input>818)
  {    
    funAllOn();
  }
  
  //else if 75% 
  //3 led on
  
  if( input>613 && input <=818)
  {
    funAllOff();
    funThreeOn();
  }
  
  //else if 50%
  //2 led on
   if( input>409 && input <=613)
  {
     funAllOff();
     funTwoOn();
  }
  
  //else if 25%
  //1 led on
  if( input>204 && input <=409)
  {
    funAllOff();
    funOneOn();
  }
  
  //else 
  //all led off
  if(input<=204)
  {
    funAllOff();
  } 
    
  
}

void funAllOff()
{
  digitalWrite(7,LOW);
  digitalWrite(6,LOW);
  digitalWrite(5,LOW);
  digitalWrite(4,LOW);
}

void funOneOn()
{
  digitalWrite(7,HIGH);  
}
void funTwoOn()
{
  digitalWrite(7,HIGH);  
  digitalWrite(6,HIGH);  
}
void funThreeOn()
{
  digitalWrite(7,HIGH);  
  digitalWrite(6,HIGH); 
  digitalWrite(5,HIGH);
}
void funAllOn()
{
  digitalWrite(7,HIGH);  
  digitalWrite(6,HIGH); 
  digitalWrite(5,HIGH);
  digitalWrite(4,HIGH);
}









