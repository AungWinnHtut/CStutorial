#   This is an Adventure Game about The Digital Sweet Shop
#   The program was written by Me
#   Date:
#
#
#   The next few lines give the introduction

print("Welcome to the Digital Sweet Shop")
print()
#   Hint : fix the indentation
print("You have been invited to take part in a competition in the shop.")
print("You must find the cholote room where you will be asked a question")
print("If you get it right you will receive letters which are part of a password and a clue.")
print()

print("You have been invited to take part in a competition in the shop. ")
print("You must find the cholote room where you will be asked two questions. ")
print("If you get it right you will receive letters which are part of a password. and a clue. ")
print()
print("At the end you must figure out the password and use it to open the ")
print("treasure chest wich contains a year's supply of all your favourite sweets. ")
print("You will meet two people - one is the sweet owner who wants to steal the password so he can keep the sweets ")
print("W E L C O M E    T O     T H E   D I G I T A L   S W E E T   S H O P ")
print()

playername = input('What is your name: ')
playerage = int(input('How old are you: '))

if playerage >= 8 and playerage <= 12:
    print("You can play the game!")
    ownername = input("Please enter owner name: ")
    robotname = input("Please enter robot name: ")
    enterroom = input("Will you enter the room? : ")

    if enterroom == "Y":
        print("You are now at upstair!")
        direction = input("Left or Right? : ")
        if direction == "R":
            print("Ahh there is a hole! You are dead now!")
        if direction == "L":
            print("You are now at the Chocolate room!")

    else:
        print("You are a coward!")


else:
    print("Sorry, You cannot play the game!")
