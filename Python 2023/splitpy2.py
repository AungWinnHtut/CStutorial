from os.path import exists


index = "012345678901234567890"
name = input('enter your name: ')
id = input('enter your id: ')
fname = name+id+'.dat'

file_exists = exists(fname)
if not file_exists:
    print("error! no such file")
    exit()

f = open(fname, 'rt')
lines = f.readlines()
for text in lines:
    mylist = text.split("%")
    for data in mylist:
        print(data)
    print()

f.close()
