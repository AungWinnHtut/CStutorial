from cmath import exp
from math import sqrt
import random

one = 0
two = 0
three = 0
four = 0
five = 0
six = 0
freq = []  # [12,11,9,]

for i in range(0, 10000):
    dice = random.randrange(1, 7)
    match dice:
        case 1:
            one += 1
        case 2:
            two += 1
        case 3:
            three += 1
        case 4:
            four += 1
        case 5:
            five += 1
        case 6:
            six += 1

print(" 1 = ", one)
print(" 2 = ", two)
print(" 3 = ", three)
print(" 4 = ", four)
print(" 5 = ", five)
print(" 6 = ", six)
