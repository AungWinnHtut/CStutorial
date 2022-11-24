
import os
os.system("cls")

l = [10, 2, 3, 4, 5, 6]
w = (20, 45, 33, 22, 66, 77)
a = [0, 0, 0, 0, 0, 0]

l[5] = 100

for i in range(6):
    a[i] = l[i]*w[i]

print(a)
