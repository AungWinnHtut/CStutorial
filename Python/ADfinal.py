#   This is an Adventure Game about The Digital Sweet Shop
#   The program was written by Dr. Aung Win Htut
#   Date: 04-03-2022
#   Green Hackers Online Traing Courses
#   0-robot.py, 1-adgame3.py, 2-entershop.py, 3-ifelse2.py, 4-input.py, 5-ad62.py, 6-ad63.py
#   The next few lines give the introduction
# Greetings my friend. if you want to go to the Digital Sweet Shop you must walk across
# the long street and turn left at the traffic lights. There is a large shopping centre
# on the corner. Turn left here and you will see the Digital Sweet Shop beside the flower
# shop. The flowershop owner has a dog called Biscuit who barks all the time. Be careful
# he can bite!

playerlives = 3
chocolate = 2
bonus = 0
numbercorrect = 0

print()
print()
print()
print("                                Game Intro")
print("                                ===========")
print("Greetings my friend. if you want to go to the Digital Sweet Shop you must walk across")
print("the long street and turn left at the traffic lights. There is a large shopping centre")
print("on the corner. Turn left here and you will see the Digital Sweet Shop beside the flower")
print("shop. The flowershop owner has a dog called Biscuit who barks all the time. Be careful")
print("he can bite!")
print()

print("                     Welcome to the Digital Sweet Shop")
print()

print("You have been invited to take part in a competition in the shop.")
print("You must find the cholote room where you will be asked a question")
print("If you get it right you will receive letters which are part of a password and a clue.")

print()
print()
print("At the end you must figure out the password and use it to open the ")
print("treasure chest wich contains a year's supply of all your favourite sweets. ")
print("You will meet two people - one is the sweet owner who wants to steal the password so he can keep the sweets ")
print("     W E L C O M E    T O     T H E   D I G I T A L   S W E E T   S H O P ")
print()

playername = input('What is your name: ')
playerage = int(input('How old are you: '))

print('Your name is ' + playername)
print('Your age is ' + str(playerage))
print()

if playerage >= 8 and playerage <= 12:
    print("You can play the game!")
    print()
    print()
    print("You can give the two people in the story names ")
    ownername = input("Please enter owner name: ")
    robotname = input("Please enter robot name: ")
    print()
    print()
    # Enter the shop??
    print("You walk up the steps to the shop....you open the door. There is nobody there")
    print("and the shop looks to be in bad repair. ")
    enterroom = input("Will you enter the room? : ")

    if enterroom == "Y" or enterroom == "y":
        print()
        print()
        print("You have reached the top of the stairs and you can go right or left")
        direction = input("Left or Right? : ")
        if direction == "R" or direction == "r":
            print()
            print()
            print("You have fallen through the hole in the floor and lost a life - ")
            print(" you must start again! GameOver")

        elif direction == "L" or direction == "l":
            print()
            print()
            print("You are standing at the door of the Chocolate room!")
            print()
            print()
            print("-----------------------------------------------------------------")
            print(
                "The door opens and someone is standing there. It is the robot " + robotname)
            print(
                "He tells you that you cannot enter unless you show that you know all about secure passwords.")
            print("He asks you a question")
            print()
            print()
            print("Hello " + playername +
                  " Which of the following would be a good strong password?")
            print("If you answer correctly he will give two bars of chocolate")
            print("1 DigitalSweetShop, 2 Botty, 3 N*123MGx*")
            print()

            # enter a print statement which will tell the user to enter a number between 1 and 3
            playerchoice = input("Please enter your choice: ")

            # enter an if statement to check if playeranswer is equal to 3
            if playerchoice == "3":
                # enter an assignment statement to increase chocolate by 2
                chocolate = chocolate + 2
                # enter a print statement to say "You have got two bars of chocolate, open the wrappers to see the two letters"
                print()
                print()
                print(
                    "You have got two bars of chocolate, open the wrappers to see the two letters")
                # enter another print statement to say "You have letters A and R - memorise these"
                print("You have letters A and R - memorise these")

                # MEETING THE OWNER
                print()
                print()
                print(
                    "Welcome to the Chocolate Room. I am the owner of this sweet shop, my name is " + ownername)
                print("You must answer this question.")
                print()
                # add an input statement to ask the question on the next line and store the response in a variable called answer
                # "Which of the following could be used as a good password"
                # "1. Your pet's name. 2. Password123 3. A random collection of numbers and letters?"
                # HINT : User answer = int(input(.......))

                print("Which of the following could be used as a good password")
                print(
                    "1. Your pet's name. 2. Password123 3. A random collection of numbers and letters?")
                print()
                answer = int(input("Please Choose 1,2,3: "))

                if answer == 3:
                    chocolatebar = int(
                        input("Do you want chocolate bar 1 or 2? "))
                    if chocolatebar == 1:
                        print()
                        print()
                        print(
                            "Hard luck, you lOse a life and there is no information in the wrapper. GameOver")
                        playerlives = playerlives - 1

                    # add code to check if the chocolate bar is equal to 1
                    # ---> add code to print this message to the user "Hard luck, you lse a life and there is no information in the wrapper"
                    # ---> add code to subtract 1 from the player lives
                    elif chocolatebar == 2:
                        print()
                        print()
                        print(
                            "OK - you can have the chocolate bar and the letter in the wrapper is T")
                        # the player must try to guess the password
                        print("Now you must enter each letter that you remember ")
                        print("You will be given 3 times")

                        # add code here for a while loop using that counts from 1 to 3, so player has 3 guesses:
                        i = 0
                        while i < 3:
                            i = i + 1
                            letter = input("Try number " + str(i)+" : ")
                            if letter == "A" or letter == "R" or letter == "T" or letter == "a" or letter == "r" or letter == "t":
                                numbercorrect = numbercorrect + 1
                                print("CORRECT - welldone")
                            else:
                                print("Wrong - sorry")
                        print()
                        print()
                        guess = input(
                            "NOW try and guess the password **** - the clue is in this line four times. Use the letters you were gives to help : ")

                        if guess == "star":
                            print()
                            print()
                            print(
                                "You are a star - you have opened the treasure chest of sweets and earned 1000 points")
                            bonus = 1000

                        score = (chocolate * 50) + (playerlives * 60) + bonus

                        # add code here to output playername
                        # add code here to output the number of bars of chocolate the player has
                        # add code here to output number of lives he player has
                        # add code here to output number of bonus points the player has
                        # add code here to output the player's score

                        print("Finally you won the game!!!")
                        print()
                        print()
                        print("Game Data")
                        print("----------")
                        print("Player Name : " + playername)
                        print("Total Chocolate Bar = " + str(chocolate))
                        print("Playerlives = " + str(playerlives))
                        print("Bonus point  = " + str(bonus))
                        print("Player's Score = " + str(score))
                        # you won the game !!!!
                        # end

                else:
                    print(
                        "Wrong answer - you lose a life and all of your chocolate and GameOver")
                    chocolate = 0
                    playerlives = playerlives - 1
                    # add code to set the chocolate value to 0
                    # add code to subtract 1 from player lives

            # enter else:
            else:
                # enter a print statement to say "You have not guessed correctly so you have lost a life"
                print("You have not guessed correctly so you have lost a life")
                playerlives = playerlives - 1

        elif direction == "S" or direction == "s":
            print("wrong room!")

    else:
        print("You are a coward!!!...Goodbye, GameOver")


else:
    print(playername+"You are not the correct age to play this game!!! Sorry !! ")
