print()
print("Quiz App")
print("---------")

marks = 0

ans = input("what is the longest river in the world : ")
if (ans == "Nile" or ans == "nile"):
    marks += 20
else:
    print("Wrong answer! The correct one is Nile")

print()
print("Your marks is " + str(marks))

print()
ans = input("what is the highest mountain in the world : ")
if (ans == "Everest" or ans == "everest"):
    marks += 20
else:
    print("Wrong answer! The correct one is Everest")

print()
print("Your marks is " + str(marks))

print()
ans = input("what is the highest mountain in the world : ")
if (ans == "Everest" or ans == "everest"):
    marks += 20
else:
    print("Wrong answer! The correct one is Everest")

print()
print("Your marks is " + str(marks))

print()
ans = input("what is the highest mountain in the world : ")
if (ans == "Everest" or ans == "everest"):
    marks += 20
else:
    print("Wrong answer! The correct one is Everest")

print()
print("Your marks is " + str(marks))

# calculation marks
print()
if(marks > 70):
    print("Excellent Marks")
elif(marks < 70 and marks > 50):
    print("Good marks")
else:
    print("You need to try again!")
