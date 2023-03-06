print('I am Dr. Aung Win Htut')

name = 'Aung Win Htut'
age = 34
phone = '095506082'
weight = input('enter weight in pounds: ')
weight = float(weight)
height = input('enter height in inches: ')
height = float(height)

BMI = (weight/(height*height))*703

print('Your BMI is : ', BMI)
