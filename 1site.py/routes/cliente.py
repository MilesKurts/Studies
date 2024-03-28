from flask import Blueprint

cliente_route = Blueprint("cliente ", __name__)

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
    return {"pagina": 'lista_clientes'}

@cliente_route.route("/")
def inserir_cliente():
    '''Iserir dados do cliente no banco de dados'''
    pass

@cliente_route.route("/new")
def form_cliente():     
    ''' Formulario para cadastro de cliente'''
    return {'pagina': 'formulario clientes'}

@cliente_route.route("/<int:cliente_id>")
def detalhe_cliente(cliente_id):
    '''Exibir detalhes do cliente'''
    pass

@cliente_route.route("/<int:cliente_id>/edit")
def form_edit_cliente(cliente_id):
    '''Formulario para editar um cliente'''
    pass
    
@cliente_route.route("/<int:cliente_id>/update", methods=['PUT'])
def atualizar_cliente(cliente_id):
    '''Atualizar informações do cliente cliente'''
    pass

@cliente_route.route("/<int:cliente_id>/update", methods=['DELETE'])
def deletar_cliente(cliente_id):
    '''deletar um cliente'''
    pass