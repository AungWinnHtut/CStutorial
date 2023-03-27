x = 50
y = 50

gx = 58
gy = 10
print('Game is Starting...')
print('Your initial position is x = {}, y = {}'.format(x, y))
while True:
    key = input()
    if key == 'a':
        x -= 1
    elif key == 'd':
        x += 1
    elif key == 'w':
        y -= 1
    elif key == 's':
        y += 1
    print('You moved to x = {}, y = {}'.format(x, y))
    if (x == gx) and (y == gy):
        print("Wow, you found the gold pot!!!")
        exit()
