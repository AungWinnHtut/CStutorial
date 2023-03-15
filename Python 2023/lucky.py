
zero = "you are lucky in this year,...."
one = "you are normal in this year,...."
two = "you are unlucky in this year,...."

year = eval(input('Birth year: '))
month = eval(input('Birth month: '))
day = eval(input('Birth day: '))

sum = year + month + day
mod = sum % 3
print("Lucy Star Baydin")
if mod == 0:
    print(zero)
elif mod == 1:
    print(one)
elif mod == 2:
    print(two)
