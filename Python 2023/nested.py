# Lesson 13 Nested Loops
rows = int(input("How many rows?: "))
columns = int(input("How many columns?: "))
symbol = input("Enter a symbol use: ")

for i in range(rows):

    for j in range(columns):
        print(j, end="  ")

    print()
