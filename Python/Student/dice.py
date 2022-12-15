import random

print('BIG or SMALL?')
bet = input()
print('the dice are running....')
dice1 = random.randint(1, 6)
dice2 = random.randint(1, 6)
print('dice1 is stopping.... ', dice1)
print('dice2 is stopping.... ', dice2)
result = dice1+dice2
print('result: dice1 + dice2 = ', result)

if result > 6:
    print("BIG")
    if bet == 'BIG':  # BIG
        print('You Win!')
    else:
        print('You Lose!')
else:
    print("SMALL")
    if bet == 'SMALL':
        print('You Win!')
    else:
        print('You Lose!')
