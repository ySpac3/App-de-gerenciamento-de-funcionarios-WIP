
import mysql.connector
import pandas as pd
import json
from sqlalchemy import create_engine

host = ''
user = ''
password=''


def get_sell_data():
    url = f'mysql+mysqlconnector://{user}:{password}@{host}/bdvendas'

    engine = create_engine(url)

    query = 'SELECT * from tbvendas'
    df = pd.read_sql(query,engine)

    engine.dispose()

    return df.to_dict(orient="records")

def  get_login_data(dict) -> bool:
    url = f'mysql+mysqlconnector://{user}:{password}@{host}/bdvendas'

    engine = create_engine(url)

    query = 'SELECT name,password,cdg FROM tbloginsellers'

    df = pd.read_sql(query,engine)
    mask = pd.Series(True,index=df.index)
    
    for key,value in dict.items():
        mask &= (df[key] == value)

    response = mask.any()

    engine.dispose()

    return bool(response)

def updade_login_status(dict,mode):
    if mode == 1:
        url = f'mysql+mysqlconnector://{user}:{password}@{host}/bdlogins'

        engine = create_engine(url)

        
        command = "UPDATE tbsellerstatus SET status = :status WHERE name = :name and cdg = :cdg"
        params = {"status":"ATIVO","name":dict["name"],"cdg":dict["cdg"]}
        
        with engine.connect() as conn:
            with conn.begin():
                conn.execute(command,params)

    engine.dispose()

def get_seller_status():
        url = f'mysql+mysqlconnector://{user}:{password}@{host}/bdlogins'

        engine = create_engine(url)
        query = 'SELECT name,status,cdg from tbsellerstatus'
        df = pd.read_sql(query,engine)

        engine.dispose()

        return df.to_dict(orient="records")


