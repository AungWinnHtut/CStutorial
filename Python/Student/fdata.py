import os
os.system("cls")
f = open("d:\\area.dat", "wt")
ans = "Y"
# loop start
while ans != "N":
    # user input (r)
    r = eval(input('Please enter r : '))
    # area calculation
    a = 3.14 * r * r
    # save input and output data in file
    f.write(str(r) + " " + str(a)+"\n")
    # ask user to continue, if Y go to input again, else exit loop
    ans = input('continue calculating (Y or N)?..... : ')
    if ans == "N":
        break

f.close()

if os.path.exists("d:\\area.dat"):
    os.system("cls")
    os.system("type d:\\area.dat")
    os.system("pause")
    os.system("cls")
else:
    print("no such file")
