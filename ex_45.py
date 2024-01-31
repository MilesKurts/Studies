from random import randint
itens = ('Pedra', 'Papel', 'tesoura')
comp =randint(0,2)
print(''' Suas opções são:
      [0]pedra
      [1]Papel
      [2]Tesoura''')
jog = int(input("Qual a sua jogada? "))
print("Computador jogou {}".format(itens[comp]))
print("Jogador jogou {}".format(itens[jog]))
if comp == 0:
    if jog == 0:
        print("Empate")
    elif jog == 1:
        print("Voce venceu!")
    elif jog == 2:
        print("Voce perdeu")
if comp == 1:
    if jog == 0:
        print("Voce perdeu")
    elif jog == 1:
        print("Empate")
    elif jog == 2:
        print("Voce Venceu!")
if comp == 2:
    if jog == 0:
        print("Voce venceu!")
    elif jog == 1:
        print("Voce Perdeu")
    elif jog == 2:
        print("Empate")