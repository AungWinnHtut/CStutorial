def bmoney():
    s = eval(input('pls enter s pocket money: '))
    b = s * 2
    print('b pocket money is ', b)


def bmoney1(s):
    b = s * 2
    print('b pocket money is ', b)


def area():
    l = eval(input('enter L: '))
    w = eval(input('enter W: '))
    a = l * w
    print('area = ', a)


def area1(l, w):
    a = l * w
    print('area = ', a)


def area2(l, w):
    a = l * w
    return a


# Program Start Here
Area = area2(100, 60)

Volume = Area * 100
print('Volume = ', Volume)
