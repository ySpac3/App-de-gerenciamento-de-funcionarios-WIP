from connector import *
from flask import Flask, jsonify, request


app = Flask(__name__)

@app.route('/',methods=['GET'])
def sells():
    data = get_sell_data()
    return jsonify(data)

@app.route('/login', methods=['POST'])
def login():
    login = request.json
    response = get_login_data(login)
    if response == True:
        dt = {"name":login["name"],"cdg":login["cdg"]}
        updade_login_status(dt,1)
    return jsonify(response)

@app.route('/status', methods=['GET'])
def status():
    status = get_seller_status()
    return jsonify(status)

if __name__ == '__main__':
    app.run()


