def encode(data):
    for d in data:
        print(ord(d))


def decode(data):
    for d in data:
        print(chr(d))


######################
msg = "enemy is here"
msg2 = " sos "
cipher = [32, 115, 111, 115, 32]
encode(msg2)
decode(cipher)
