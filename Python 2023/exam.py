import random
import os

marks = 0


def funAdd():
    global marks
    print('#### This is Adding Game ####')

    for i in range(0, 1):
        a = random.randint(0, 100)
        b = random.randint(0, 100)
        sum = a + b
        print('please add a = ', a, ' and b = ', b)
        ans = eval(input('your ans: '))
        f.writelines(str(a) + '+'+str(b) + '='+str(sum)+'%')
        f.writelines(str(ans)+'%')
        if ans == sum:
            marks = marks + 1
            print('Right answer! Total marks is now ', marks)
            f.writelines('1%')
        else:
            print('Wrong answer!Total marks is now ', marks)
            f.writelines('0%')
        input()
        f.writelines('\n')
        os.system("cls")


def funMul():
    global marks
    print('#### This is Multiplying Game ####')

    for i in range(0, 1):
        a = random.randint(0, 100)
        b = random.randint(0, 100)
        mul = a * b
        print(a, ' * ', b, ' = ')
        ans = eval(input())
        f.writelines(str(a) + '*'+str(b) + '='+str(mul)+'%')
        f.writelines(str(ans)+'%')

        if ans == mul:
            marks = marks + 1
            print('Right answer! Total marks is now ', marks)
            f.writelines('1%')
        else:
            print('Wrong answer!Total marks is now ', marks)
            f.writelines('0%')

        input()
        f.writelines('\n')
        os.system("cls")


print('#### This is Math Game ####')
name = input('What is your name: ')
student_id = input('What is your student ID: ')
file_name = name+student_id+".dat"
global f
f = open(file_name, 'at')

while 1:
    print('1-Adding Game')
    print('2-Multiplying Game')
    print('3-Exit')
    choice = input('Please choose 1 or 2: ')
    if choice == '1':
        funAdd()
    elif choice == '2':
        funMul()
    elif choice == '3':
        f.close()
        quit()
    os.system('cls')
