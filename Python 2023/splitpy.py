index = "012345678901234567890"
text = "test*program*language"
# print(string[:4])   # second - 1* index
# print(string[5:12])  # first - 1* index +1 : second - 2* index
# print(string[13:])   # first - 2* index +1


firstindex = text.find("*")
secondhalfstring = text[firstindex+1:]
secondindex = secondhalfstring.find("*")+firstindex+1
print(text[:firstindex])
print(text[firstindex+1:secondindex])
print(text[secondindex+1:])


mylist = text.split("*")
print(mylist)
