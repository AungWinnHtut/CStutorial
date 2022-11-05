// CONNECTIONS:
// DS1302 CLK/SCLK --> 5
// DS1302 DAT/IO --> 4
// DS1302 RST/CE --> 2
// DS1302 VCC --> 3.3v - 5v
// DS1302 GND --> GND

#include <ThreeWire.h>
#include <RtcDS1302.h>

ThreeWire myWire(4, 5, 2);  // IO, SCLK, CE
RtcDS1302<ThreeWire> Rtc(myWire);

void setup() {
  Serial.begin(57600);

  Serial.print("compiled: ");
  Serial.print(__DATE__);
  Serial.println(__TIME__);

  Rtc.Begin();

  RtcDateTime compiled = RtcDateTime(__DATE__, __TIME__);
  printDateTime(compiled);
  Serial.println();

  if (!Rtc.IsDateTimeValid()) {
    // Common Causes:
    //    1) first time you ran and the device wasn't running yet
    //    2) the battery on the device is low or even missing

    Serial.println("RTC lost confidence in the DateTime!");
    Rtc.SetDateTime(compiled);
  }

  if (Rtc.GetIsWriteProtected()) {
    Serial.println("RTC was write protected, enabling writing now");
    Rtc.SetIsWriteProtected(false);
  }

  if (!Rtc.GetIsRunning()) {
    Serial.println("RTC was not actively running, starting now");
    Rtc.SetIsRunning(true);
  }

  RtcDateTime now = Rtc.GetDateTime();
  if (now < compiled) {
    Serial.println("RTC is older than compile time!  (Updating DateTime)");
    Rtc.SetDateTime(compiled);
  } else if (now > compiled) {
    Serial.println("RTC is newer than compile time. (this is expected)");
  } else if (now == compiled) {
    Serial.println("RTC is the same as compile time! (not expected but all is fine)");
  }
}

void loop() {
  RtcDateTime now = Rtc.GetDateTime();
  Serial.print("RTC time reading is: ");
  printDateTime(now);
  Serial.println();
  String sMonth = getMonth(now);
  Serial.print("Month: ");
  Serial.println(sMonth);

  String sDay = getDay(now);
  Serial.print("Day: ");
  Serial.println(sDay);

  String sYear = getYear(now);
  Serial.print("Year: ");
  Serial.println(sYear);

  String sHour = getHour(now);
  Serial.print("Hour: ");
  Serial.println(sHour);

  String sMinute = getMinute(now);
  Serial.print("Minute: ");
  Serial.println(sMinute);

  String sSecond = getSecond(now);
  Serial.print("Second: ");
  Serial.println(sSecond);

  const char* sDateTime = getDateTime(now);
  Serial.print("DateTime: ");
  for (int k = 12; k < 14; k++) {
    Serial.print(sDateTime[k]);
  }





  if (!now.IsValid()) {
    // Common Causes:
    //    1) the battery on the device is low or even missing and the power line was disconnected
    Serial.println("RTC lost confidence in the DateTime!");
  }

  delay(10000);  // ten seconds
}

#define countof(a) (sizeof(a) / sizeof(a[0]))

void printDateTime(const RtcDateTime& dt) {
  char datestring[20];

  snprintf_P(datestring,
             countof(datestring),
             PSTR("%02u/%02u/%04u %02u:%02u:%02u"),
             dt.Month(),
             dt.Day(),
             dt.Year(),
             dt.Hour(),
             dt.Minute(),
             dt.Second());
  Serial.print(datestring);
}
String getMonth(const RtcDateTime& dt) {
  char monthString[20];

  snprintf_P(monthString,
             countof(monthString),
             PSTR("%02u"),
             dt.Month());
  return monthString;
}
String getDay(const RtcDateTime& dt) {
  char dayString[20];

  snprintf_P(dayString,
             countof(dayString),
             PSTR("%02u"),
             dt.Day());
  return dayString;
}
String getYear(const RtcDateTime& dt) {
  char yearString[20];

  snprintf_P(yearString,
             countof(yearString),
             PSTR("%04u"),
             dt.Year());
  return yearString;
}
String getHour(const RtcDateTime& dt) {
  char hourString[20];

  snprintf_P(hourString,
             countof(hourString),
             PSTR("%02u"),
             dt.Hour());
  return hourString;
}
String getMinute(const RtcDateTime& dt) {
  char minuteString[20];

  snprintf_P(minuteString,
             countof(minuteString),
             PSTR("%02u"),
             dt.Minute());
  return minuteString;
}
String getSecond(const RtcDateTime& dt) {
  char secondString[20];

  snprintf_P(secondString,
             countof(secondString),
             PSTR("%02u"),
             dt.Second());
  return secondString;
}
const char* getDateTime(const RtcDateTime& dt) {
  static char datestring[20];

  snprintf_P(datestring,
             countof(datestring),
             PSTR("%02u%02u%04u%02u%02u%02u"),
             dt.Month(),
             dt.Day(),
             dt.Year(),
             dt.Hour(),
             dt.Minute(),
             dt.Second());
  return datestring;
}