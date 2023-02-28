def greeting(name):
    print("Hello " + name)
    print()
    print()


def area(l, w):
    a = l * w
    print('area = ', a)
    print()
    print()


def tempF2C(tf):
    tc = ((5/9)*tf) - 32
    print('tc = ', tc)
    print()
    print()


def square(n):
    return n*n


def menu():
    while True:
        print('Menu')
        print('=====')
        print('1-calculate area: ')
        print('2-calculate temperature: ')
        print('3-calculate square: ')
        print('0-Exit')
        print()

        ans = input('Please choose (0,1,2,3): ')
        if (ans == '1'):
            l = eval(input('Please enter L: '))
            w = eval(input('Please enter W: '))
            area(l, w)

        elif (ans == '2'):
            tf = eval(input('Please enter tf: '))
            tempF2C(tf)

        elif (ans == '3'):
            n = eval(input('Please enter n: '))
            s = square(n)
            print('square = ', s)
            print()
            print()

        elif (ans == '0'):
            exit()


# Program Start here!
name = input('What is your name: ')
greeting(name)
menu()
