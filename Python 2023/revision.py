# 1 what you need ? BMI
# weight (lb) / [height (in)]2 x 703

# input weight, height

w = eval(input('please enter your weight in lbs : '))
hf = eval(input('please enter you height (feet): '))
hi = eval(input('please enter you height (inches): '))
h = (hf*12)+hi
bmi = (w/(h*h))*703
print('your BMI is ', bmi)

if (bmi <= 18.4):
    print('Underweight!')

if (bmi > 18.4 and bmi <= 25):
    print('Normal weight!')

if (bmi > 25 and bmi <= 40):
    print('overweight!')

if (bmi > 40):
    print('obese')
