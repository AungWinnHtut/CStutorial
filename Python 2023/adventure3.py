gx = 55
gy = 45

tx = 48
ty = 40

ux = 50
uy = 50

ans = 'start'

marks = 100

print("Game is Starting...")
print("Game Control a-left,d-right,w-up,s-down,q-quit...")
print("Your Starting Position is x={} and y={}".format(ux, uy))
print()
print()

while ans != 'q':

    ans = input(">>>")
    marks = marks - 1
    if ans == 'a':
        ux = ux - 1
    elif ans == 'd':
        ux = ux + 1
    elif ans == 'w':
        uy = uy - 1
    elif ans == 's':
        uy = uy + 1

    print("Your Current Position is x={} and y={}".format(ux, uy))

    if (ux == gx) and (uy == gy):
        print("you found the gold bag!!!")
        print("your marks is {}".format(marks))
        exit()
    elif (ux == tx) and (uy == ty):
        print("you fall into the trap, GAME OVER!!!")
        print("your marks is {}".format(marks))
        exit()
