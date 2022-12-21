import sys

print(sys.version)
print(sys.executable)


def greet(who_to_greet):
    greeting = 'Hello,{}'.format(who_to_greet)
    print(greeting)


greet('koko')
