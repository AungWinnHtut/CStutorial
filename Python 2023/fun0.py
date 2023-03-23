def area():
    # storage
    a = 0
    r = 0
    # input
    r = eval(input('please enter r: '))
    # process
    a = 3.14 * r * r
    # output
    print('area = ', a)


def area2(r):
    a = 3.14 * r * r
    print('area = ', a)


def area3(r):
    a = 3.14 * r * r
    return a


def volume(a, h):
    v = a * h
    print('volume = ', v)


def volume1(a, h):
    v = a * h
    return v


def speed(s, t):  # s - distance (miles), t - time (hour), speed (miles/hour)
    v = s / t
    return v


def time(v, s):
    t = s / v
    return t


# Program Start HERE
aa = area3(23.4)
print('area =', aa)
vv = volume1(aa, 12)
print('volume = ', vv)
vv = volume1(area3(23.4), 12)


print()
s = eval(input('Enter distance in miles: '))
t = eval(input('Enter time in hours: '))
v = speed(s, t)
print('your speed is ', v)
print()


s = eval(input('Enter distance in miles: '))
v = eval(input('Enter speed in miles per hour: '))
t = time(v, s)
print('{} hours'.format(t))
