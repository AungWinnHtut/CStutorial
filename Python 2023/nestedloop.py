# Lesson 13 Nested Loops
rows = int(input("How many rows?: "))
columns = int(input("How many columns?: "))
symbol = input("Enter a symbol use: ")

for i in range(rows):

    for j in range(columns):
        print(symbol, end="")

    print()


for hour in range(24):
    for minute in range(60):
        for second in range(60):
            print("Hour: ", hour, " Minute: ", minute, " Second: ", second)
