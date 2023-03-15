# process 1
# input , output 2
# storage 3

# 3 2 1 output

speed = 0
distance = 1200  # eval(input('pls enter distance in km: '))
time = 13  # eval(input('please enter the time: '))


for i in range(0, 10):  # 0 1 2 3 4 5 6 7 8 9
    speed = (distance / time) * i * i
    print('speed is {1} for i = {0}'.format(speed, i))
