# Guess password and output the score
chocolate = 2
playerlives = 1
playername = "Aung"
# this loop clears the screen
for i in range(1, 35):
    print()


bonus = 0
numbercorrect = 0

# the player must try to guess the password
print("Now you must ener each letter that you remember ")
print("You will be given 3 times")

# add code here for a while loop using that counts from 1 to 3, so player has 3 guesses:
i = 0
while i < 3:
    i = i + 1
    letter = input("Try number " + str(i)+" : ")
    if letter == "A" or letter == "R" or letter == "T":
        numbercorrect = numbercorrect + 1
        print("CORRECT - welldone")
    else:
        print("Wrong - sorry")

guess = input(
    "NOW try and guess the password **** - the clue is in this line four times. Use the letters you were gives to help : ")

if guess == "star":
    print("You are a star - you have opened the treasure chest of sweets and earned 1000 points")
    bonus = 1000

score = (chocolate * 50) + (playerlives * 60) + bonus

# add code here to output playername
# add code here to output the number of bars of chocolate the player has
# add code here to output number of lives he player has
# add code here to output number of bonus points the player has
# add code here to output the player's score

print("Player Name : " + playername)
print("Total Chocolate Bar = " + str(chocolate))
print("Playerlives = " + str(playerlives))
print("Bonus point  = " + str(bonus))
print("Player's Score = " + str(score))

# end
