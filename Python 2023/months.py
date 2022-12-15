months = "JanFebMarAprMayJunJulAugSepOctNovDec"

# jan 0-3    feb 3-6  mar 6-9 apr 9-12
# 0   3
# 3   6
# 6   9
# 9   12

for i in range(12):
    print(i)
    print(i*3, ":", (i+1)*3)
    print(months[i*3: (i+1)*3])

month_number = eval(input('pls enter month number 1-12: '))
print(months[(month_number-1)*3: month_number*3])
