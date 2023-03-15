ans = '-999'

while ans != '0':
    print('0-exit')
    print('1-hello')
    print('2-area')
    print('3-gold')
    ans = input('Please choose 0,1,2,3: ')
    if ans == '1':
        print('hello')
    elif ans == '2':
        print('area')
    elif ans == '3':
        print('gold')
    elif ans == '0':
        print('Exiting....')
    else:
        print('invalid choice!')
