listagem = ("laspis", 1.75,
            "Borracha", 2,
            "Caderno", 15.9,
            "estojo", 25,
            "transferidor", 4.2,
            "compasso", 9.99,
            "mochila", 120.32,
            "canetas", 22.30,
            "livro", 34.9)
print("-"*40)
print(f'{"listagem de preço":^40}')
print("-"*40)
for pos in range(0, len(listagem)):
    if pos % 2 ==0:
        print(f'{listagem[pos]:.<30}', end="")
    else:
        print(f"R${listagem[pos]:7.2f}")
print("-"*40)