from datetime import date
atual = date.today().year
nasc = int(input("Ano de nascimento: "))
idade = atual - nasc
print("Quem nasceu em {} tem {} anos em {}".format(nasc, idade, atual))
if idade == 18:
    print("Voce deve ser alistar já!")
elif idade < 18:
    saldo = 18 - idade
    print("Voce ainda nao tem 18 anos. faltam {} anos para o alistamento.".format(saldo))
elif idade >18:
    saldo = idade - 18
    print("Voce deveria ter se alistado há {} anos".format(saldo))