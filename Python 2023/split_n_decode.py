msg = input('please enter secret msg : ')
print(msg)

code = []
info = []

for m in msg.split():
    code.append(eval(m))
    ch = chr(eval(m))
    info.append(ch)

print(code)
print(info)
