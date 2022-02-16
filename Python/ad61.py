playeranswer = int(input("Enter a number between 1 and 3"))
# enter while statement with conditions here to make sure the player enter a
# number between 1 and 3
# --->enter an input statement which will tell the user to enter a number between 1 and 3

if playeranser == 3:
    chocolate = chocolate + 2
    print("You have got two bars of chocolate, open the wrappers to see the two letters")
    print("You have letters A and R - memorise these")
else:
    print("You have not guessed correctly so you have lost a life")
    playerlives = playerlives - 1
