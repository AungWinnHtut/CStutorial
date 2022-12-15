months = ["January", "February", "March", "April", "May", "June",
          "July", "August", "September", "October", "November", "December"]

month1 = "january"
# month1[0] = 'J'

months[11] = "DEC"
month_number = eval(input('pls enter month_number : '))
print(months[month_number-1])
