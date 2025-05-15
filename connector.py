
import mysql.connector
import pandas as pd
import json

def get_data():
    connection = mysql.connector.connect(
        host='',
        user='',
        password='',
        database=''
    )
    query = 'SELECT * from tbvendas'
    df = pd.read_sql(query,connection)

    connection.close()

    return df.to_dict(orient="records")


    

