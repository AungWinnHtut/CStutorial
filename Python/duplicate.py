
# Program : duplicate.py
# Programmer: Dr. Aung Win Htut
# 14-08-2022 0830PM
# version 1.0


li1 = ['a', 'a', 'b', 'b', 'b', 'a', 'b', 'aa', 'a', 'b', 'c']  # original list
temp = []  # duplicate index storage list
final = []  # after removing duplicate list

flag = True  # check in temp list, if not included True else False

for i in range(len(li1)):  # first search index i
    for j in range(i+1, len(li1)):  # second compare index i+1
        flag = True
        if temp != []:  # if temp is empty, no checking needed
            for k in temp:  # else check every elements in temp whether already present in temp
                print(i)
                print(j)
                print(k)
                print()
                if(k == j):  # already included in temp, then no need to operate that index to compare, abort
                    flag = False

        # not included in temp and duplicate then add this index to temp
        if((flag == True) and (li1[i] == li1[j])):
            temp.append(j)

print(temp)
temp.sort()
print(temp)

# must exclude index stored in temp
for i in range(len(li1)):
    flagOK = True
    for l in temp:
        if i == l:  # if this index is included in temp then must omit it
            flagOK = False

    if(flagOK == True):  # if not included in temp then safe to append to final list
        final.append(li1[i])


print("final = ")
print(final)
