
# inputs x1,x2,n,spam,k
x1 = 10
x2 = 3
n = 5
spam = 22
k = 4
X = x1-x2
twoN = 2*n
K3 = 3*k
Sratio = spam/K3

ans = (X/twoN)+Sratio

ans1 = ((x1-x2)/(2*n))+(spam/(k*3))

print(ans, end=' ')
print('\a')  # auto add \n
# print()
