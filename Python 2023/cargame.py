command = ''
while command.lower() != 'quit':
    command = input('> ')
    if command.lower() == 'start':
        print('Car is Starting....')
    elif command.lower() == 'stop':
        print('Car stopped...')
    elif command.lower() == 'quit':
        print('Game is exiting...')
    elif command.lower() == 'help':
        print("""
            start - start the car
            stop  - stop the car
            quit  - exit
        """)
    else:
        print('Error command')
