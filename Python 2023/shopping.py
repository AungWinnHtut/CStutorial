s1_price = eval(input('shop 1 rice price: '))
s2_price = eval(input('shop 2 rice price: '))

if (s1_price > s2_price):
    print("should buy from s2")

elif (s1_price < s2_price):
    print("should buy from s1")

else:
    print('any shop is OK')
