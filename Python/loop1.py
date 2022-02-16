# loop1
number = 1
while number < 10:
    print(number)
    number = number + 1

# loop2 !Check error
answer = int(input("Enter a value which is between 1 and 0 "))
while answer >= 1 and answer <= 10:
    answer = int(input("Wrong - Enter a value between 1 and 10"))

# loop3
userinput = input("Enter a letter in the range A - C")
while answer != "A" and answer != "B" and answer != "C":
    answer = input("Enter a letter in the range A-C")

# loop4
times = int(input("Which times tables do you want to see"))
number = 0
while number <= 12:
    result = times * number
    print(str(times) + "*" + str(number) + "=" + str(result))
    number = number + 1
