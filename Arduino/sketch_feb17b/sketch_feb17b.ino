#include <LiquidCrystal_I2C.h>

LiquidCrystal_I2C lcd(0x3F, 16, 2); // I2C address 0x27, 16 column and 2 rows

byte customChar0[8] = {
  0b00000,
  0b01010,
  0b11111,
  0b11111,
  0b01110,
  0b00100,
  0b00000,
  0b00000
};

byte customChar1[8] = {
  0b00100,
  0b01110,
  0b11111,
  0b00100,
  0b00100,
  0b00100,
  0b00100,
  0b00100
};

byte customChar2[8] = {
  0b00100,
  0b00100,
  0b00100,
  0b00100,
  0b00100,
  0b11111,
  0b01110,
  0b00100
};

void setup()
{
  lcd.init(); // initialize the lcd
  lcd.backlight();

  lcd.createChar(0, customChar0); // create a new custom character (index 0)
  lcd.createChar(1, customChar1); // create a new custom character (index 1)
  lcd.createChar(2, customChar2); // create a new custom character (index 2)

  lcd.setCursor(2, 0); // move cursor to (2, 0)
  lcd.write((byte)0);  // print the custom char 0 at (2, 0)

  lcd.setCursor(4, 0); // move cursor to (4, 0)
  lcd.write((byte)1);  // print the custom char 1 at (4, 0)

  lcd.setCursor(6, 0); // move cursor to (6, 0)
  lcd.write((byte)2);  // print the custom char 2 at (6, 0)
}

void loop()
{
}

byte customChar[8] = {
  0b00000,
  0b01010,
  0b11111,
  0b11111,
  0b01110,
  0b00100,
  0b00000,
  0b00000
};
