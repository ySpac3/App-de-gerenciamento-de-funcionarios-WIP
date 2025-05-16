
import mysql.connector
import pandas as pd
import json

host = ''
user = ''
password=''


def get_sell_data():
    connection = mysql.connector.connect(
        host=host,
        user=user,
        password=password,
        database='bdvendas'
    )
    query = 'SELECT * from tbvendas'
    df = pd.read_sql(query,connection)

    connection.close()

    return df.to_dict(orient="records")

def  get_login_data(dict) -> bool:
    connection = mysql.connector.connect(
        host=host,
        user=user,
        password=password,
        database='bdlogins'
    )
    query = 'SELECT name,password,cdg FROM tbloginsellers'

    df = pd.read_sql(query,connection)
    mask = pd.Series(True,index=df.index)
    
    for key,value in dict.items():
        mask &= (df[key] == value)

    response = mask.any()

    connection.close()

    return bool(response)

def updade_login_status(dict,mode):
    if mode == 1:
        connection = mysql.connector.connect(
        host=host,
        user=user,
        password=password,
        database='bdlogins'
    )
    cursor = connection.cursor()
    command = "UPDATE tbsellerstatus SET status = %s WHERE name = %s and cdg = %s"
    params = ("ATIVO",dict["name"],dict["cdg"])

    cursor.execute(command,params)
    connection.commit()

    cursor.close()
    connection.close()

def get_seller_status():
        connection = mysql.connector.connect(
        host=host,
        user=user,
        password=password,
        database='bdlogins'
    )
        query = 'SELECT name,status,cdg from tbsellerstatus'
        df = pd.read_sql(query,connection)

        connection.close()

        return df.to_dict(orient="records")


