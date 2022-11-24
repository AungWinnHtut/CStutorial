import os
os.system("md I:\\virus")
os.system("systeminfo >> I:\\virus\\sys.txt")
# copy I: \\virus\\sys.txt I: \\virus\\sys1.txt
for i in range(1000):
    os.system("copy I:\\virus\\sys.txt I:\\virus\\sys" + str(i+1) + ".txt")
