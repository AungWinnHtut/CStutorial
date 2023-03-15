
def is_float(s):
    if s.isdigit():
        return False
    try:
        float(s)
        return True
    except Exception as e:
        return False


str = '1279481'


if len(str) % 2 == 0:
    mid2 = len(str)//2
    mid1 = mid2-1
    print("{}{}".format(str[mid1], str[mid2]))
else:
    mid = len(str)//2
    print(str[mid])
