from flask import Flask
from routes.home import home_route
#beggin flask
app = Flask(__name__)

 #routs
app.register_blueprint(home_route)

#final flask
app.run(debug=True)
