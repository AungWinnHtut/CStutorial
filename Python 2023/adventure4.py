
import os
gx = 55
gy = 45

tx = 48
ty = 40

ux = 50
uy = 50

ans = 'start'

marks = 100

name = input('What is your name (no space please): ')
file_name = 'D:\\game\\'+name+'.txt'
command = 'notepad '+file_name

game_file = open('d:\\gamedata.txt', 'a')
leader_board = open(file_name, 'a')

print("Game is Starting...")
print("Game Control a-left,d-right,w-up,s-down,q-quit...")
print("Your Starting Position is x={} and y={}".format(ux, uy))
game_file.write("Your Starting Position is x={} and y={}\n".format(ux, uy))
print()
print()

while ans != 'q':

    ans = input(">>>")
    game_file.write(ans+'\n')
    marks = marks - 1
    if ans == 'a':
        ux = ux - 1
    elif ans == 'd':
        ux = ux + 1
    elif ans == 'w':
        uy = uy - 1
    elif ans == 's':
        uy = uy + 1
    elif ans == 'q':
        leader_board.write(str(marks)+'\n')
        game_file.close()
        leader_board.close()
        os.system(command)
        exit()

    print("Your Current Position is x={} and y={}".format(ux, uy))
    game_file.write("Your Current Position is x={} and y={}\n".format(ux, uy))

    if (ux == gx) and (uy == gy):
        print("you found the gold bag!!!")
        game_file.write("you found the gold bag!!!\n")
        print("your marks is {}".format(marks))
        game_file.write("your marks is {}\n".format(marks))
        leader_board.write(str(marks)+'\n')
        leader_board.close()
        game_file.close()
        os.system(command)
        exit()
    elif (ux == tx) and (uy == ty):
        print("you fall into the trap, GAME OVER!!!")
        game_file.write("you fall into the trap, GAME OVER!!!\n")
        print("your marks is {}".format(marks))
        game_file.write("your marks is {}\n".format(marks))
        leader_board.write(str(marks)+'\n')
        leader_board.close()
        game_file.close()
        os.system(command)
        exit()
