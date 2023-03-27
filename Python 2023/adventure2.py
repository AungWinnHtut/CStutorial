gx = 58
gy = 10

ux = 50
uy = 50

key = 'start'

print('Game is Starting...')
print('Use A,D,W,S kyes to move...')
print('You are in the middle of no where now!!! x = {} and y= {}'.format(ux, uy))

while key != 'q':
    key = input()
    if key.lower() == 'a':
        print('you move to left....')
        ux = ux - 1
        if ux < 0:
            ux = 0
    elif key.lower() == 'd':
        print('you move to right....')
        ux = ux + 1
        if ux > 100:
            ux = 100
    elif key.lower() == 'w':
        print('you move to up....')
        uy = uy - 1
        if uy < 0:
            uy = 0
    elif key.lower() == 's':
        print('you move to down....')
        uy = uy + 1
        if uy > 100:
            uy = 100

    print('Your current location is now at x = {} and y= {}'.format(ux, uy))

    if (ux == gx) and (uy == gy):
        print('You found the gold bag!!!')
        print()
        print()
        exit()
