def encode(data):
    for d in data:
        print(ord(d))


def decode(data):
    for d in data:
        print(chr(d))


msg = input('pls enter your message : ')
encode(msg)

cipher = []

num = eval(input('please enter a secrect number (-1 to end) : '))
while (num >= 0):
    cipher.append(num)
    num = eval(input('please enter a secrect number (-1 to end) : '))

print(cipher)

decode(cipher)
