print("Hi I'm Botty the robot. Please enter the five scores that you")
print("need me to find the average of")

score1 = int(input("Enter score 1: "))
score2 = int(input("Enter score 2: "))
score3 = int(input("Enter score 3: "))
score4 = int(input("Enter score 4: "))
score5 = int(input("Enter score 5: "))


# change the total score calculation to include score3, score4, score5
totalscore = score1 + score2 + score3 + score4 + score5

# change the formala for average to find the average of 5 values
average = totalscore / 5.0

print('Average score is ' + str(average))
print()
