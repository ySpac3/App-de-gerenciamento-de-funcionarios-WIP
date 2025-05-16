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
    print(login)
    return jsonify(response)

if __name__ == '__main__':
    app.run()


