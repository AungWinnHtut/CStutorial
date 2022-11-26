lstnum = [2, 13, 4, 15, 6, 7]
sum_of_odd = 0

for inum in lstnum:
    mod = inum % 2
    if mod != 0:
        sum_of_odd = sum_of_odd + inum

print("Sum of odd numbers is ", sum_of_odd)
