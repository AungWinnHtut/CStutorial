lstnum = [2, 13, 4, 15, 6, 7]
sum_of_odd = 0

for i in range(6):
    mod = lstnum[i] % 2
    if mod != 0:
        sum_of_odd = sum_of_odd + lstnum[i]

print("Sum of odd numbers is ", sum_of_odd)
