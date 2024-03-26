from flask import Flask, url_for, render_template

#beggin flask
app = Flask(__name__)

 #routs
@app.route("/")
def ola_mundo():
    return render_template('index.html')

@app.route("/sobre")
def pagina_sobre():
    return "Eae bro!"

#final flask
app.run(debug=True)
