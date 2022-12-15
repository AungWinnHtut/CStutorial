principle = eval(input('pls enter principle : '))
interest = eval(input('pls enter interest : '))  # 0.5

# principle = principle + (interest * principle)
for i in range(10):
    principle = principle*(1+interest)


print(principle)

#
