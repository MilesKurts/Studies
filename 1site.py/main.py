from flask import Flask, url_for, render_template

#beggin flask
app = Flask(__name__)

 #routs
@app.route("/")
def ola_mundo():
    titulo = "Gestão usuarios"
    usuarios = [
        {"nome": "Guilherme", "membro_ativo": True},
        {"nome": "joao", "membro_ativo": False},
        {"nome": "Maria", "membro_ativo": False},
    ]

    return render_template('index.html', titulo=titulo,usuarios=usuarios)

@app.route("/sobre")
def pagina_sobre():
    return "Eae bro!"

#final flask
app.run(debug=True)
