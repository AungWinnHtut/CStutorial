# loop2 !Check error
answer = int(input("Enter a value which is between 1 and 10 : "))
count = 0
while answer <= 1 or answer >= 10:
    count += 1
    print("Your answer wrong " + str(count) + " times")
    answer = int(input("Wrong - Enter a value between 1 and 10 : "))


print("Answer is correct NOW")
