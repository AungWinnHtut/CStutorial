name = input('What is your name: ')
place = input('Where do you live: ')
sex = input("Male(m) of Female(f)?: ")
print('Hello ' + name)

if (sex == 'm'):
    print('He lives in ' + place)
else:
    print('She lives in ' + place)
a = 3
b = 4
c = a + b
print('a =', a)
print('b = ', b)
print('c = ', c)

print('a = {}, b = {}, c = {}'.format(a, b, c))
