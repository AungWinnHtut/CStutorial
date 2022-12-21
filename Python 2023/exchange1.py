
rate = eval(input('Please enter dollar exchange rate with kyats: '))
D = []
K = []

while True:
    dollars = eval(input('Please enter amount of dollars (zero to exit) : '))
    if dollars != 0:
        D.append(dollars)
        print(D)
    else:
        break


for d in D:
    K.append(d*rate)


print(K)
