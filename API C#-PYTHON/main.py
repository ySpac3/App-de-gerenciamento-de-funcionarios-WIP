from connector import *
from flask import Flask, jsonify, request


app = Flask(__name__)

@app.route('/',methods=['GET'])
def sells():
    data = get_data()
    return jsonify(data)

@app.route('/login', methods=['POST'])
def login():
    login = request.json
    return jsonify(True)

if __name__ == '__main__':
    app.run()


