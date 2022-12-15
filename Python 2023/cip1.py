msg = "enemy is here!"
encode = []

for ch in msg:
    encode.append(ord(ch))

print('encoded data:')
for n in encode:
    print(n)


decode = []

for e in encode:
    decode.append(chr(e))

print('decoded data:')
for d in decode:
    print(d)

cipher = []
decipher = []

for e in encode:
    cipher.append(e+3)

print('cipher data:')
for c in cipher:
    print(c)


print('cipher char data:')
for c in cipher:
    print(chr(c))


for c in cipher:
    decipher.append(c-3)

print('decipher data:')
for dc in decipher:
    print(dc)

print('decipher char data:')
for dc in decipher:
    print(chr(dc))
