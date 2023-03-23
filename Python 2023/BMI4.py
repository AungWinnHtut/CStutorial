
W = eval(input('Weight: '))
H = eval(input('Height: '))
BMI = (W/(H*H)) * 703

print('Your BMI is ', BMI)

if BMI < 18.4:
    print('you are underweight')
