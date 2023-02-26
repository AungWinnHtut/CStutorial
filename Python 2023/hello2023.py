name = input('What is Your name: ')
age = eval(input('How old are you: '))
birthday = input("What is your birthday: ")
address = input('Where do you live: ')
phone = input('What is your Phone number: ')
id = input('What is your ID number: ')
weight = eval(input("Weight(lb): "))
height = eval(input('Height (inches): '))


# BMI calculation
BMI = (weight/(height * height))*703


print()
print()

print("Student Profile")
print("================")
print('Name: ', name)
print('age: ', age)
print('birthday: ', birthday)
print('address: ', address)
print('phone: ', phone)
print('id: ', id)
print('weight: ', weight)
print('height: ', height)
print('Your BMI is : ', BMI)
