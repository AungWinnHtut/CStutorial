myanmar = eval(input('Enter your Myanmar Marks: '))
english = eval(input('Enter your English Marks: '))

exam_pass = 1  # 1 - pass, 0 - fail

if ((myanmar > 40) and (english < 40)):
    print('you passed the exam')
else:
    print('you failed the exam')
