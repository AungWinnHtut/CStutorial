
weight = eval(input('Weight in lbs: '))
height = eval(input('Height in inches: '))

h_sq = height ** 2
BMI = (weight/h_sq)*703


print('Your BMI is ', BMI)
