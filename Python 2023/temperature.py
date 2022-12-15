# job: read deg C then conver to deg F

# storage (I\O) no need in python

# input Tc
Tc = float(input('please enter deg C : '))
# process
Tf = ((9/5)*Tc+32)  # inputs - right of = , output left of =
# output Tf
print(Tf)


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

print(ans, end='\n')
print()
print(ans1)
