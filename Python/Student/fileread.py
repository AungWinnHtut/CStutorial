fr = open("chaos.py", "rt")
#data = fr.readline()

for line in fr:
    if not '#' in line:
        print(line)

fr.close()  # save
