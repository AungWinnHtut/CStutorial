import pymysql

try:
    con = pymysql.connect(
        host='localhost',
        port=3306,
        user='root',
        password='',
        db='test'
    )
except pymysql.err.OperationalError as e:
    print('cant connect database : error code is ', e)

cursor = con.cursor()

# Define the SQL query
table = 'student_table'
sql = "INSERT INTO " + table + " (id,name, age) VALUES (%s,%s, %s)"

# Define the data to be inserted
data = (9, 'tester', 25)

# Execute the SQL query
try:
    cursor.execute(sql, data)
    con.commit()
    print("Data inserted successfully")
except pymysql.Error as e:
    con.rollback()
    print("Error inserting data:", e)


try:
    cursor.execute('select * from student_table')
except pymysql.err.ProgrammingError as e:
    print('Cannot execute query : error code is ', e)

results = cursor.fetchall()  # read answer

for row in results:
    print(row)


# Define the SQL query
table = 'student_table'
sql = "update " + table + " set name=%s where id=%s"

# Define the data to be inserted
data = ('dog', 3)

# Execute the SQL query
try:
    cursor.execute(sql, data)
    con.commit()
    print("Data inserted successfully")
except pymysql.Error as e:
    con.rollback()
    print("Error inserting data:", e)


try:
    cursor.execute('select * from student_table')
except pymysql.err.ProgrammingError as e:
    print('Cannot execute query : error code is ', e)

results = cursor.fetchall()  # read answer

for row in results:
    print(row)


# Define the SQL query
table = 'student_table'
sql = "delete from " + table + " where id=%s"

# Define the data to be inserted
data = (10)

# Execute the SQL query
try:
    cursor.execute(sql, data)
    con.commit()
    print("Data inserted successfully")
except pymysql.Error as e:
    con.rollback()
    print("Error inserting data:", e)


try:
    cursor.execute('select * from student_table')
except pymysql.err.ProgrammingError as e:
    print('Cannot execute query : error code is ', e)

results = cursor.fetchall()  # read answer

for row in results:
    if (row[0] == 7):
        print(row)

cursor.close()
con.close()
