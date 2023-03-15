sum = 0
num = 1
max = eval(input('what is the max number to add: '))

while num <= max:
    sum = sum + num
    num = num + 1

print("sum of 1 to 100 = {}".format(sum))
