# enter the Chocolate Rooom
print("Welcome to the Chocolate Room. I am the owner of this sweet shop, my name is " + ownername)
print("You must answer this question.")

# add an input statement to ask the question on the next line and store the response in a variable called answer
# "Which of the following could be used as a good password"
# "1. Your pet's name. 2. Password123 3. A random collection of numbers and letters?"
# HINT : User answer = int(input(.......))

if answer == 3:
    chocolatebar = int(input("Do you want chocolate bar 1 or 2? "))
    # add code to check if the chocolate bar is equal to 1
    # ---> add code to print this message to the user "Hard luck, you lse a life and there is no information in the wrapper"
    # ---> add code to subtract 1 from the player lives
    elif chocolatebar == 2:
        print("OK - you can have the chocolate bar and the letter in the wrapper is T")

else:
    print("Wrong answer - you lose a life and all of your chocolate")
    # add code to set the chocolate value to 0
    # add code to subtract 1 from player lives
