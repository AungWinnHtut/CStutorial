import calendar
for i in range(12):  # 0-11
    cal1 = calendar.month(2023, 1+i)
    print("Here is the calendar:")
    print(cal1)
