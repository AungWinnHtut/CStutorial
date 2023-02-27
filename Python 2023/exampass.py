myanmar = eval(input('Enter your Myanmar Marks: '))
english = eval(input('Enter your English Marks: '))

exam_pass = 1  # 1 - pass, 0 - fail

if (myanmar < 40):
    exam_pass = 0
elif (english < 40):
    exam_pass = 0

if (exam_pass == 1):
    print('you passed the exam')
else:
    print('you failed the exam')
