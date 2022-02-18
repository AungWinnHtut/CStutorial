# loop4
times = int(input("Which times tables do you want to see : "))
number = 0
while number < 12:
    number = number + 1
    result = times * number
    #   2 * 1 = 2
    #   time * number = result
    print(str(times) + " * " + str(number) + " = " + str(result))
