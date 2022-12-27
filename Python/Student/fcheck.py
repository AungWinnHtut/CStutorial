import os
import sys
os.system("cls")
radius = []
area = []
dict = {}
dict1 = {'apple': 'ပန်းသီး'}
#file_name = input("Please enter filename: ")
file_name = "d:\\area.dat"
if not os.path.exists(file_name):
    print("no such file "+file_name)
    sys.exit()


f = open(file_name, "rt")  # r - read only , t - text file
for line in f:
    line = line.replace('\n', '')
    data = line.split(' ')
    r = eval(data[0])
    radius.append(r)
    a = eval(data[1])
    area.append(a)
    dict[r] = a

f.close()

print(radius)
print(area)
print(dict)

i = 0
for rr in radius:
    if rr == 3.3:
        break
    else:
        i = i+1

print("area of r=3.3 is ", area[i])

s = eval(input("which r value ? "))
print("dict search result of 3.3 is ", dict1['apple'])
