// Programmer Dr. Aung Win Htut
// Founder of Green Hackers
#include <Wire.h> 
#include <LiquidCrystal_I2C.h>
LiquidCrystal_I2C lcd(0x27,20,4);

class DebouncedButton {
public:
  DebounceButton(uint_fast8_t pin, unsigned long debounceDelay) {
    pinMode(pin, INPUT);
    this->_debounceDelay = debounceDelay;
    this->_pin = pin;
  };
 
  void loop() {
    bool currentButtonState = digitalRead(this->_pin);
    auto currentTime = millis();
 
    if (currentButtonState == this->_state)
      this->_lastSameState = currentTime;
    else if ((this->_lastSameState + this->_debounceDelay) <= currentTime)
      this->_state = currentButtonState;
  };
 
  bool getState() {
    return this->_state;
  };
 
private:
  unsigned long _debounceDelay;
  uint8_t _pin;
 
  unsigned long _lastSameState = 0;
  bool _state = LOW;
};
 
const uint_fast8_t PUSH_BUTTON_PIN = 11;
const uint_fast8_t UP_BUTTONPIN = 12;
const uint_fast8_t DOWN_BUTTON_PIN = 13;
const uint_fast8_t BUZZER_PIN = 10;
const uint_fast8_t RELAY_PIN = 2;
 
const unsigned long DEBOUNCE_DELAY = 100;  // the debounce time; increase if the output flickers
DebouncedButton push_button(PUSH_BUTTON_PIN, DEBOUNCE_DELAY);
DebouncedButton up_button(UP_BUTTONPIN, DEBOUNCE_DELAY);
DebouncedButton down_button(DOWN_BUTTON_PIN, DEBOUNCE_DELAY);
 
bool push_button_last_state = LOW;
bool up_button_last_state = LOW;
bool down_button_last_state = LOW;
 
int seconds = 0;
int time_delay = 0;  //0.3 ms
 

 
void setup() {
  pinMode(RELAY_PIN, OUTPUT);
  pinMode(BUZZER_PIN, OUTPUT);
 
  lcd.init();
  lcd.backlight();
  lcd.setCursor(0, 0);
  lcd.print("    Kyaw Electronics");
  lcd.setCursor(1, 1);
  lcd.print("Spot Time ");
  Serial.begin(9600);
}
 
void loop() {
  push_button.loop();
  up_button.loop();
  down_button.loop();
 
  bool push_button_state = push_button.getState();
  if (push_button_state != push_button_last_state) {
    push_button_last_state = push_button_state;
    if (push_button_state == HIGH) {
      //relay on after timer
      digitalWrite(RELAY_PIN, HIGH);
      digitalWrite(BUZZER_PIN, HIGH);
      delay(time_delay);
      digitalWrite(BUZZER_PIN, LOW);
      digitalWrite(RELAY_PIN, LOW);
      delay(3000);
    }
  }
 
  bool up_button_state = up_button.getState();
  if (up_button_state != up_button_last_state) {
    up_button_last_state = up_button_state;
 
    if (up_button_state == HIGH) {
      //Increace delay time by 1 ms
      time_delay++;
      Serial.print(F("Time Delay: "));
      Serial.println(time_delay);
    }
  }
 
  bool down_button_state = down_button.getState();
  if (down_button_state != down_button_last_state) {
    down_button_last_state = down_button_state;
 
    if (down_button_state == HIGH) {
      //Decreace delay time by 1 ms
      time_delay--;
      Serial.print(F("Time Delay: "));
      Serial.println(time_delay);
    }
  }
 
  lcd.setCursor(11, 1);
  lcd.print(time_delay);
}
