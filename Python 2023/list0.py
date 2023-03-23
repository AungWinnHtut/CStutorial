total = 0
avg = 0
sub = ['myn', 'eng', 'maths']
marks1 = [55, 66, 67]

marks1 = marks1 * 3
print(marks1)
print()

marks = [45, 67, 88, 45, 36, 77]
marks = marks1 + marks
print(marks)
print()


del marks[0]
print(marks)
print()

for m in marks:
    total = total + m

avg = total / len(marks)

print('avg = ', avg)

if 77 in marks:
    print('77 include')
else:
    print('77 not include')


print('maximum marks is ', max(marks))
print('minimum marks is ', min(marks))
print('100 count is ', marks.count(100))
print('first index of 66 ', marks.index(66))
print('first index of 88 ', marks.index(88))
marks.insert(7, 100)
print(marks)
print('first index of 88 ', marks.index(88))
marks.remove(55)
print(marks)
print('first index of 88 ', marks.index(88))
marks.reverse()
print(marks)
marks.sort(reverse=True)
print(marks)
marks.pop()
marks.pop(marks.index(100))
print(marks)
