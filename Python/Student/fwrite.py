import os
os.system("cls")


f = open("d:\\hello.py", "wt")
f.writelines("print('Hello World')\n")
f.writelines("print(22+4)\n")
f.close()

if os.path.exists("d:\\hello.py"):
    os.system("type d:\\hello.py")
    os.system("pause")
    os.system("cls")
    os.system("python d:\\hello.py")
else:
    print("no such file")
