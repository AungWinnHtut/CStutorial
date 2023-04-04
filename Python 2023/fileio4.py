#user defined function for sign in
def Signin(uname, passwd,filename):    
   login_file= open(filename,'r')      #r read only 
    
   funame=login_file.readline()         #return one line from the file
   fpasswd=login_file.readline()

   funame = funame.rstrip('\n')         #remove characters, space is the default trailing character to remove.
   fpasswd = fpasswd.rstrip('\n')
   login_file.close()
   #print('Username = {} \nPassword = {} \n\n'.format(uname, passwd))
   if uname != funame or passwd != fpasswd:
        return False
   else:
        return True

#user defined function for reset
def ResetSignin(olduname, oldpass, filename):       
    if not Signin(olduname, oldpass, filename):     #call for Signin  function
        print('Wrong username or password:')
        return False                                # Fail to update password
 
    newpass = 'u1'
    newpass2 = 'u2'

    while newpass != newpass2:
        newuname = input('Please Enter New Username: ')
        newpass = input('Please Enter New Password: ')
        newpass2 = input('Please Enter New Password again: ')
        if newpass != newpass2:
            print('Passwords do not match!, pls try again\n')

    login_file = open(filename, 'w')  # w to override
    login_file.write(newuname+'\n')
    login_file.write(newpass+'\n')
    login_file.close()
    return True                       # Success

#user defined function for printpass
def PrintPass(filename):
    # w - write, + means you can read too
    login_file = open(filename, 'r')
    funame = login_file.readline()
    fpasswd = login_file.readline()
    funame = funame.rstrip('\n')
    fpasswd = fpasswd.rstrip('\n')
    login_file.close()
    print('Username = {} \nPassword = {} \n\n'.format(funame, fpasswd))
 

#Main Start Here
username = input('Enter Username: ')
password = input('Enter Password: ')
if not Signin(username, password, 'd:\\game\\login.dat'):
   print('Error')
   exit()


ans = -1
while ans != '0':
    print("You are logging in....")
    print()
    print('1- Change Username and Password: ')
    print('2- Print Username and Password: ')
    print('0- Exit')
    ans = input('Please choose (0,1): ')
    if ans == '0':
        exit()
    elif ans == '1':
        olduname = input('Please Enter Old username: ')
        oldpass = input('Please Enter Old password: ')
        status = ResetSignin(olduname, oldpass, 'd:\\game\\login.dat')      #call reset function
        if status == True:
            print('Login Reset Success!')
        else:
            print('Login Reset Fail!')
    elif ans == '2':
            PrintPass('d:\\game\\login.dat')
            exit()
    else:
            print('Invalid choice, please choose only 0 and 1 : \n\n')
         