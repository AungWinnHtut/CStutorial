
def len_(s):
    count = 0
    for c in s:
        count += 1
    return count


def reverse_(s):
    ss = ''
    size = len_(s)
    for i in range(size):    # 0 - size-1
        ss = ss + s[size-1-i]  # 9 8 7
    print(ss)


num = 423432
str1 = '1234567890'

size = len_(str1)
print(size)
if size % 2 == 0:  # even
    print('even')
    mid2 = size//2
    mid1 = mid2-1
    print('{}{}'.format(str1[mid1], str1[mid2]))
else:
    print('odd')
    mid = size//2
    print(str1[mid])


reverse_(str1)
