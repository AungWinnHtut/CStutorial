# Use a loop to make sure the user enters Y or N
enterhouse = input("Do you enter the shop? Enter Y for yes and N for no ")
count = 0
while enterhouse != "Y" and enterhouse != "N":
    count = count + 1
    print("You wrong "+str(count)+" times")
    enterhouse = input("Enter Y or N please... ")

print("End")
