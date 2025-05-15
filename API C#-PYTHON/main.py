from connector import *
from flask import Flask, jsonify


app = Flask(__name__)

@app.route('/',methods=['GET'])
def sells():
    data = get_data()
    return jsonify(data)


if __name__ == '__main__':
    app.run()


