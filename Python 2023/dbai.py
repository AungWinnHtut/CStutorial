# Function to create a connection to the database
def connect_to_database(db_name):
    try:
        conn = pymysql.connect(host='localhost',
                               user='root',
                               password='',
                               database=db_name)
        print("Connected to the database successfully")
        return conn
    except Exception as e:
        print("Error connecting to the database: ", e)

# Function to create a new database


def create_database(conn, db_name):
    try:
        cursor = conn.cursor()
        cursor.execute("CREATE DATABASE %s", (db_name,))
        conn.commit()
        print("Database created successfully")
    except Exception as e:
        conn.rollback()
        print("Error creating database: ", e)

# Function to drop an existing database


def drop_database(conn, db_name):
    try:
        cursor = conn.cursor()
        cursor.execute("DROP DATABASE %s", (db_name,))
        conn.commit()
        print("Database dropped successfully")
    except Exception as e:
        conn.rollback()
        print("Error dropping database: ", e)

# Function to create a new table


def create_table(conn, table_name, columns):
    try:
        cursor = conn.cursor()
        cursor.execute("CREATE TABLE %s (%s)", (table_name, columns))
        conn.commit()
        print("Table created successfully")
    except Exception as e:
        conn.rollback()
        print("Error creating table: ", e)

# Function to drop an existing table


def drop_table(conn, table_name):
    try:
        cursor = conn.cursor()
        cursor.execute("DROP TABLE %s", (table_name,))
        conn.commit()
        print("Table dropped successfully")
    except Exception as e:
        conn.rollback()
        print("Error dropping table: ", e)

# Function to insert data into a table
# insert_data(conn, "mytable", "(1, 'John')")


def insert_data(conn, table_name, values):
    try:
        cursor = conn.cursor()
        query = "INSERT INTO %s VALUES (%s)"
        cursor.executemany(query, [(table_name, value) for value in values])
        conn.commit()
        print("Data inserted successfully")
    except Exception as e:
        conn.rollback()
        print("Error inserting data: ", e)


# Function to select data from a table
def select_data(conn, table_name, columns="*", condition=None):
    try:
        cursor = conn.cursor()
        if condition is None:
            query = "SELECT %s FROM %s"
            cursor.execute(query, (columns, table_name))
        else:
            query = "SELECT %s FROM %s WHERE %s"
            cursor.execute(query, (columns, table_name, condition))
        result = cursor.fetchall()
        for row in result:
            print(row)
    except Exception as e:
        conn.rollback()
        print("Error selecting data: ", e)

# Function to alter an existing table


def alter_table(conn, table_name, action):
    try:
        cursor = conn.cursor()
        query = "ALTER TABLE %s %s"
        cursor.execute(query, (table_name, action))
        conn.commit()
        print("Table altered successfully")
    except Exception as e:
        conn.rollback()
        print("Error altering table: ", e)
