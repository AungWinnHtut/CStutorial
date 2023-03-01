
# Import all
import pymysql
import os


def insert_db(conn, tb_name, columns, values):
    try:
        cursor = conn.cursor()
        # sql = "INSERT INTO area_tb (l,w,a) VALUES (%s,%s,%s)"
        sql = "INSERT INTO {0} ({1}) VALUES ({2})".format(
            tb_name,  # 0
            ", ".join(columns),  # 1
            ", ".join(["%s"] * len(columns))  # 2
        )
        cursor.execute(sql, values)
        conn.commit()
        print('Data insert complete')
    except Exception as e:
        conn.rollback()
        print('Error inserting data: ', e)


def greeting(name):
    print("Hello " + name)
    print()
    print()


def area(l, w):
    a = l * w
    print('area = ', a)
    columns = ('l', 'w', 'a')
    values = (l, w, a)
    insert_db(conn, 'area_tb', columns, values)
    os.system('pause')
    os.system('cls')
    print()
    print()


def tempF2C(tf):
    tc = ((5/9)*tf) - 32
    print('tc = ', tc)
    columns = ('tf', 'tc')
    values = (tf, tc)
    insert_db(conn, 'temp_tb', columns, values)
    os.system('pause')
    os.system('cls')
    print()
    print()


def square(n):
    square_n = n*n

    columns = ('n', 'square_n')
    values = (n, square_n)
    insert_db(conn, 'square_tb', columns, values)
    os.system('pause')
    os.system('cls')
    print()
    print()
    return (square_n)


def menu():
    while True:
        print('Menu')
        print('=====')
        print('1-calculate area: ')
        print('2-calculate temperature: ')
        print('3-calculate square: ')
        print('0-Exit')
        print()

        ans = input('Please choose (0,1,2,3): ')
        if (ans == '1'):
            l = eval(input('Please enter L: '))
            w = eval(input('Please enter W: '))
            area(l, w)

        elif (ans == '2'):
            tf = eval(input('Please enter tf: '))
            tempF2C(tf)

        elif (ans == '3'):
            n = eval(input('Please enter n: '))
            s = square(n)
            print('square = ', s)
            print()
            print()

        elif (ans == '0'):
            exit()


# Program Start here!

# test code ends here
# name = input('What is your name: ')
# greeting(name)

server = 'localhost'
admin = 'root'
pwd = ''
dbname = 'calculation_db'

try:
    conn = pymysql.connect(host=server,
                           user=admin,
                           password=pwd,
                           database=dbname
                           )
    print('Successfully connected to {} database'.format(dbname))
except Exception as e:
    print('Cannot connect ot' + dbname + 'database')

os.system('pause')
os.system('cls')
menu()
