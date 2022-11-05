// Programmer Dr. Aung Win Htut
// Founder of Green Hackers
#include <Adafruit_LiquidCrystal.h>


const int push_button = 11;
const int up_button = 12;
const int down_button = 13;
const int buzzer = 10;
const int relay = 2;

int push_button_state = LOW;
int push_button_last_state = LOW;
int up_button_state = LOW;
int up_button_last_state = LOW;
int down_button_state = LOW;
int down_button_last_state = LOW;

unsigned long lastDebounceTime_push_button = 0;  // the last time the output pin was toggled
unsigned long lastDebounceTime_up_button = 0;
unsigned long lastDebounceTime_down_button = 0;
unsigned long debounceDelay = 500;  // the debounce time; increase if the output flickers

int seconds = 0;
int time_delay = 0;  //0.3 ms

Adafruit_LiquidCrystal lcd_1(0);

void setup() {
  pinMode(push_button, INPUT);
  pinMode(up_button, INPUT);
  pinMode(down_button, INPUT);
  pinMode(relay, OUTPUT);   //relay
  pinMode(buzzer, OUTPUT);  //buzzer

  lcd_1.begin(16, 2);
  lcd_1.setCursor(0, 0);
  lcd_1.print("    Kyaw Electronics");
  lcd_1.setCursor(1, 1);
  lcd_1.print("Spot Time ");
  Serial.begin(9600);
}

void loop() {
  // read the state of the switch into a local variable:
  int reading_push_button = digitalRead(push_button);
  Serial.print("Push button state ");
  Serial.println(reading_push_button);
  int reading_up_button = digitalRead(up_button);
  int reading_down_button = digitalRead(down_button);

  // check to see if you just pressed the button
  // (i.e. the input went from LOW to HIGH), and you've waited long enough
  // since the last press to ignore any noise:

  // If the switch changed, due to noise or pressing:
  if (reading_push_button != push_button_last_state) {
    // reset the debouncing timer
    Serial.print("Push button state changed ");
    Serial.println(reading_push_button);
    lastDebounceTime_push_button = millis();
  }

  if ((millis() - lastDebounceTime_push_button) > debounceDelay) {
    // whatever the reading is at, it's been there for longer than the debounce
    // delay, so take it as the actual current state:
    Serial.print("Debounce over ");
    Serial.println(reading_push_button);
    // if the button state has changed:
    if (reading_push_button != push_button_state) {
      push_button_state = reading_push_button;


      // only toggle the LED if the new button state is HIGH
      if (push_button_state == HIGH) {
        //relay on after timer
        digitalWrite(relay, HIGH);
        digitalWrite(buzzer, HIGH);
        delay(time_delay);
        digitalWrite(relay, LOW);
        digitalWrite(buzzer, LOW);
      }
    }
  }

  // If the switch changed, due to noise or pressing:
  if (reading_up_button != up_button_last_state) {
    // reset the debouncing timer
    lastDebounceTime_up_button = millis();
  }

  if ((millis() - lastDebounceTime_up_button) > debounceDelay) {
    // whatever the reading is at, it's been there for longer than the debounce
    // delay, so take it as the actual current state:

    // if the button state has changed:
    if (reading_up_button != up_button_state) {
      up_button_state = reading_up_button;
      lcd_1.setCursor(11, 1);
      lcd_1.print("p");
      // only toggle the LED if the new button state is HIGH
      if (up_button_state == HIGH) {
        //Increace delay time by 1 ms
        time_delay++;
        Serial.print("Time Delay: ");
        Serial.println(time_delay);
        lcd_1.setCursor(11, 1);
        lcd_1.print(time_delay);
      }
    }
  }

  // If the switch changed, due to noise or pressing:
  if (reading_down_button != down_button_last_state) {
    // reset the debouncing timer
    lastDebounceTime_down_button = millis();
  }

  if ((millis() - lastDebounceTime_down_button) > debounceDelay) {
    // whatever the reading is at, it's been there for longer than the debounce
    // delay, so take it as the actual current state:

    // if the button state has changed:
    if (reading_down_button != down_button_state) {
      down_button_state = reading_down_button;

      // only toggle the LED if the new button state is HIGH
      if (reading_down_button == HIGH) {
        //Decreace delay time by 1 ms
        time_delay--;
        Serial.print("Time Delay: ");
        Serial.println(time_delay);
        lcd_1.setCursor(11, 1);
        lcd_1.print(time_delay);
      }
    }
  }



  // save the reading. Next time through the loop, it'll be the lastButtonState:
  push_button_state = reading_push_button;
  up_button_state = reading_up_button;
  down_button_state = reading_down_button;

  lcd_1.setCursor(11, 1);
  lcd_1.print(time_delay);
}