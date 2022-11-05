/*
 * Programmer : Dr. Aung Win Htut
 * Date       : 16-07-2022
 * Version    : 2.1
 * Note       : In serial monitor, choose the 
 *              baud rate 9600 and No line ending
 */
#include <LiquidCrystal.h>
int rs=2;
int en=3;
int d4=8;
int d5=9;
int d6=10;
int d7=11;

int seconds = 0;

LiquidCrystal lcd(rs,en,d4,d5,d6,d7);

float firstNum;
float secNum;
float answer;
String op;

void setup()
{
  lcd.begin(16, 2);
  Serial.begin(9600);

  lcd.print("hello world");
  delay(1000);
}

void loop()
{
  lcd.clear();
  lcd.setCursor(0, 0);
  Serial.println();
  Serial.print("Input 1st Number");
  lcd.print("Input 1st Number");
  while (Serial.available() == 0){   
    //loop to wait until serial data input (No line ending)
  }
  firstNum=Serial.parseFloat();
  
  lcd.setCursor(0,1);
  lcd.print(String(firstNum));
  Serial.print(" : ");
  Serial.println(String(firstNum));
  delay(1000);
  lcd.clear();

  lcd.setCursor(0,0);
  Serial.print("Input 2nd Number");
  lcd.print("Input 2nd Number");
  while ( Serial.available() == 0 ){  
    //loop to wait until serial data input (No line ending)
  }  
  secNum=Serial.parseFloat();

  Serial.print(" : ");
  Serial.println(String(secNum));
  lcd.setCursor(0,1);  
  lcd.print(String(secNum));
  delay(1000);
  lcd.clear();

  lcd.setCursor(0,0);
  Serial.print("Input(+,-,*,/)");
  lcd.print("Input(+,-,*,/)");
  while (Serial.available()==0){  
    //loop to wait until serial data input (No line ending)
  }
  op=Serial.readString();
  Serial.print(" : ");
  Serial.println(op);
  
  if (op == "+"){
    answer=firstNum+secNum;
  }
  if (op=="-"){
    answer=firstNum-secNum;
  }
  if (op=="*"){
    answer=firstNum*secNum;
  }
  if (op=="/") {
    answer=firstNum/secNum;
  }
  lcd.clear();
  Serial.print(firstNum);
  lcd.setCursor(0,0);  
  lcd.print(firstNum);

  Serial.print(op);
  lcd.print(op);

  Serial.print(secNum);
  lcd.print(secNum);
  
  Serial.print(" = ");
  lcd.print(" = ");

  Serial.println(answer);
  lcd.setCursor(0,1);  
  lcd.print(answer);
  
  delay(5000);
  Serial.println("Thank You");
  lcd.setCursor(0,0);
  lcd.clear();
  lcd.print("Thank You");
  delay(1000);
  lcd.clear();
}
