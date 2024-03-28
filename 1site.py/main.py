from flask import Flask
from routes.home import home_route
from routes.cliente import cliente_route
#beggin flask
app = Flask(__name__)

 #routs
app.register_blueprint(home_route)
app.register_blueprint(cliente_route, url_prefix='/clientes')


#final flask
app.run(debug=True)
