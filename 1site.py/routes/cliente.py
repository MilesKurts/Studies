from flask import Blueprint, render_template, request
from database.cliente import CLIENTES

cliente_route = Blueprint("cliente", __name__)

'''
Rota de clientes
    -
    -/clientes/ (GET)- Listar Clientes
    -/clientes/ (POST) <id> - inserir dados de um cliente no servidor
    -/clientes/new(GET) - renderizar um formulario para criar um novo cliente
    -/clientes/<id>(GET) - obter dados de um cliente
    -/clientes/<id>/edit(GET) - renderizar um formulario para editar um cliente
    -/clientes/<id>/update (PUT) - atualizar dados do cliente
    -/clientes/<id>/del -  deleta registro do usuario

'''


@cliente_route.route("/")
def lista_clientes():
    '''Listar clientes'''
    return render_template('lista_clientes.html', clientes=CLIENTES)

@cliente_route.route('/', methods=['POST'])
def inserir_cliente():
    """ inserir os dados do cliente """
    
    data = request.json
    
    novo_usuario = {
        "id": len(CLIENTES) + 1,
        "nome": data['nome'],
        "email": data['email'],
    }

    CLIENTES.append(novo_usuario)

    return render_template('item_cliente.html', cliente=novo_usuario)
    

@cliente_route.route("/new")
def form_cliente():     
    ''' Formulario para cadastro de cliente'''
    return render_template('form_cliente.html')

@cliente_route.route("/<int:cliente_id>")
def detalhe_cliente(cliente_id):
    '''Exibir detalhes do cliente'''

    cliente = list(filter(lambda c: c['id'] ==  cliente_id, CLIENTES))[0]
    return render_template('detalhe_cliente.html', cliente=cliente)

@cliente_route.route("/<int:cliente_id>/edit")
def form_edit_cliente(cliente_id):
    '''Formulario para editar um cliente'''
    cliente = None
    for c in CLIENTES:
        if c['id'] == cliente_id:
            cliente = c
    return render_template('form_cliente.html', cliente=cliente)
    
@cliente_route.route("/<int:cliente_id>/update", methods=['PUT'])
def atualizar_cliente(cliente_id):

    data = request.json
    #obter dados do formulario de edição
    '''Atualizar informações do cliente cliente'''

    #obter usuarios pelo id
    for c in CLIENTES:
        if c['id'] == cliente_id:
            c['nome'] = data['nome']
            c['email'] = data['email']

            cliente_editado = c
    
    #editar usuario
    return render_template('item_cliente.html', cliente=cliente_editado)

@cliente_route.route("/<int:cliente_id>/update", methods=['DELETE'])
def deletar_cliente(cliente_id):
    global CLIENTES
    '''deletar um cliente'''
    CLIENTES = [ c for c in CLIENTES if c['id'] != cliente_id ]

    return {'deleted': "ok"}