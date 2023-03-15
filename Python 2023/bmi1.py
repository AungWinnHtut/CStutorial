
weight = eval(input('Pls enter weight: '))
height = eval(input('Pls enter height: '))

bmi = (weight/(height*height))*703

print("BMI = {}".format(bmi))


if bmi < 18.4:
    print('Underweight')

elif bmi >= 18.4 and bmi < 25:
    print('normal')

elif bmi >= 25 and bmi < 40:
    print('overweight')

else:
    print('obese')
