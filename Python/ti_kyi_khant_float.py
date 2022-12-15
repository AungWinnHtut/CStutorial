def recreate(mystr):
    mystr = mystr.replace("-", "")
    mystr = mystr.replace("+", "")
    testnum = mystr
    startnum = 0
    endnum = 0
    ans = ""
    for i in range(len(testnum)):
        if testnum[i] != "0":
            startnum = i
            break

    ans = testnum[startnum:]

    for z in range(len(ans) - 1, 0, -1):
        if ans[z] != "0":
            endnum = z
            break

    ans1 = ans[:endnum + 1]
    return ans1


usrin1 = input("Enter your num: ")
usrin = str(usrin1)
expopt = 0
newstr1 = ""
if "+" in usrin and "." not in usrin:
    usrin = usrin.replace("+", "")
    numstr = recreate(usrin)
    expopt = len(usrin) - 1
    for x in range(len(numstr)):
        if x == 1:
            newstr1 += "."
        newstr1 += numstr[x]
elif "-" in usrin and "." not in usrin:
    usrin = usrin.replace("-", "")
    numstr = recreate(usrin)
    expopt = len(usrin) - 1
    for x in range(len(numstr)):
        if x == 0:
            newstr1 += "-"
        if x == 1:
            newstr1 += "."
        newstr1 += numstr[x]
elif "." not in usrin:
    numstr = recreate(usrin)
    expopt = len(usrin) - 1
    for x in range(len(numstr)):
        if x == 1:
            newstr1 += "."
        newstr1 += numstr[x]


def recreate(mystr):
    mystr = mystr.replace("-", "")
    mystr = mystr.replace("+", "")
    testnum = mystr
    startnum = 0
    endnum = 0
    ans = ""
    for i in range(len(testnum)):
        if testnum[i] != "0":
            startnum = i
            break

    ans = testnum[startnum:]

    for z in range(len(ans) - 1, 0, -1):
        if ans[z] != "0":
            endnum = z
            break

    ans1 = ans[:endnum + 1]
    return ans1


if "." in usrin:
    numstr = recreate(usrin)
    for i in range(len(numstr)):
        if numstr[i] == ".":
            expopt = i - 1
    newstr = numstr.replace(".", "")
    if "+" in usrin1:
        for z in range(len(newstr)):
            if z == 0:
                newstr1 += "+"
            if z == 1:
                newstr1 += "."
            newstr1 += newstr[z]
    elif "-" in usrin1:
        for z in range(len(newstr)):
            if z == 0:
                newstr1 += "-"
            if z == 1:
                newstr1 += "."
            newstr1 += newstr[z]
    elif "+" not in usrin1 and "-" not in usrin1:
        for z in range(len(newstr)):
            if z == 1:
                newstr1 += "."
            newstr1 += newstr[z]


# print(newstr1)
# print(expopt)
print(f"{newstr1}({expopt})")
