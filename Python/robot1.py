robotname = "Botty"
playername = "Aung"
playerlive = 3
chocolate = 2


print()
print()
print("--------------------------------------------------------------------------------")
print("The door opens and someone is standing there. It is the robot " + robotname)
print("He tells you that you cannot enter unless you show that you know all about secure passwords.")
print("He asks you a question")
print()
print()
print("Hello " + playername +
      " Which of the following would be a good strong password?")
print("If you answer correctly he will give two bars of chocolate")
print("1 DigitalSweetShop, 2 Botty, 3 N*123MGx*")

# enter a print statement which will tell the user to enter a number between 1 and 3
playerchoice = input("Please enter your choice: ")

# enter an if statement to check if playeranswer is equal to 3
if playerchoice == "3":
    # enter an assignment statement to increase chocolate by 2
    chocolate = chocolate + 2
    # enter a print statement to say "You have got two bars of chocolate, open the wrappers to see the two letters"
    print("You have got two bars of chocolate, open the wrappers to see the two letters")
    # enter another print statement to say "You have letters A and R - memorise these"
    print("You have letters A and R - memorise these")

# enter else:
else:
    # enter a print statement to say "You have not guessed correctly so you have lost a life"
    print("You have not guessed correctly so you have lost a life")
    playerlive = playerlive - 1
