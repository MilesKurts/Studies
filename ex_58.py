from random import randint
comp = randint(0,10)
print("ADIVINHE O NUMERO")
acertou = False
palpites = 0
while not acertou:
    jog = int(input("Qual seu palpite?"))
    palpites += 1
    if jog == comp:
        acertou = True
    else:
        if jog < comp:
            print("Coloca mais!")
        else:
            print("Coloca menos!")
print("Acertou!")
print("Seus palpites foram {}".format(palpites))