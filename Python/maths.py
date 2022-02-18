print("Famous 3x+1 problem")
print("---------------------")
x = int(input("To test please enter an integer : "))

while True:
    if x % 2 == 0:
        x = x/2
    else:
        x = 3 * x + 1

    print("X = " + str(x))
    #input('Next Number')
