numeros = list()
while True:
    n = int(input("Digite um numero:"))
    if n not in numeros:
        numeros.append(n)
        print("Adicinado com sucesso")
    else:
        print("Ja existe esse numero!")
    r = str(input("voce quer continuar? (N/S) ")).strip()[0]
    if  r == "n" or r == "N":
        break
print(f"Voce adicionou esses numeros: {sorted(numeros)}")