distance = input('Enter Distance of your travel in miles: ')
distance = float(distance)
distance = distance * 1.069
time = input('Enter period of your travel in hours: ')
time = float(time)
speed = distance/time
print('speed of car is : {} km per hour\n for distance = {} km and time = {} hour'.format(
    speed, distance, time))
