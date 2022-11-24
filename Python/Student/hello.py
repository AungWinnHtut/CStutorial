# Here functions are defined
def Area():
    l = 10
    w = 5
    A = l * w
    print("Area is ", A)
############################


# Program Start Here
# Program to find the sum of all numbers stored in a list

# List of numbers
marks = [65, 45, 73, 88]
pass_sub = 0
fail_sub = 0

for mark in marks:
    if (mark >= 50):
        pass_sub = pass_sub + 1
    else:
        fail_sub = fail_sub + 1

print("Pass subjs = ", pass_sub)
print("Fail subjs = ", fail_sub)
