

lstnum = []

while True:
    num = int(input('Please enter a number : '))
    if num < 0:
        break
    else:
        lstnum.append(num)


sum_of_odd = 0
sum_of_even = 0

for inum in lstnum:
    mod = inum % 2
    if mod != 0:
        sum_of_odd = sum_of_odd + inum
    else:
        sum_of_even += inum

print("Sum of odd numbers is ", sum_of_odd)
print("Sum of even numbers is ", sum_of_even)
