
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

# Function to select data from a table


def select_data(conn, table_name, columns="*", condition=None):
    try:
        cursor = conn.cursor()
        if condition is None:
            # query = "SELECT * FROM area_tb"
            query = "SELECT {0} FROM {1}".format(
                columns,  # 0
                table_name
            )
            cursor.execute(query)
        else:
            query = "SELECT {0} FROM {1} WHERE {2}".format(
                columns,  # 0
                table_name,
                condition
            )
            cursor.execute(query)

        result = cursor.fetchall()
        # print(data)
        return result

    except Exception as e:
        conn.rollback()
        print("Error selecting data: ", e)


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
        print('4-show calculated area data')
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

        elif (ans == '4'):
            result = select_data(conn, "area_tb", "*", None)
            print(' ID             L              W               A')
            for row in result:
                print('{0:3d}    {1:10.2f}     {2:10.2f}      {3:10.2f}'.format(
                    row[0], row[1], row[2], row[3]))

            os.system('pause')

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

except Exception as e:
    print('Cannot connect ot' + dbname + 'database')
    os.system('pause')


os.system('cls')
print('Successfully connected to {} database'.format(dbname))
print()
menu()
