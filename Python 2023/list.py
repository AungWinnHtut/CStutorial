#!/usr/bin/python3

import calendar

print("Here is the calendar:")
for year in range(2023, 2034):
    for month in range(1, 13):
        cal = calendar.month(year, month)
        print(cal)
