
weight = eval(input("Weight(lb): "))
height = eval(input('Height (inches): '))


# BMI calculation Arithmetic Operations + - * / %
BMI = (weight/(height * height))*703


print()
print()


print('Your BMI is : ', BMI)

# Locical Operation > < == != , and or
if (BMI < 18.4):
    print('Underweight!')
elif (BMI >= 18.4 and BMI < 25):
    print('BMI normal')
elif (BMI >= 25 and BMI < 40):
    print('Overweight')
elif (BMI >= 40):
    print('Obese')
