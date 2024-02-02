somaidade = 0
media = 0
maior = 0
nomevelho = ""
tot20 = 0
for p in range(1,5):
    print("-"*5,"Pessoa", "-"*5)
    nome = str(input("Nome: "))
    idade =  int(input("Idade: "))
    sexo =  str(input("SEXO [M/F]:")).strip()
    somaidade += idade
    if p == 1 and sexo in "Mm":
        maior = idade
        nomevelho = nome
    if sexo in "Mm" and idade > maior:
        maior = idade
        nomevelho = nome
    if sexo in "Ff"and idade<20:
        tot20+=1

media = somaidade/4
print("A media é {}".format(media))
print("Homem mais velho tem {} e se chama {}".format( maior,nomevelho))
print("Tem {} mulher(es) com mais de 20 anos no grupo".format(tot20))