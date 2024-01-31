dividendo = int(input("Qual o numero da tabuada voce quer fazer? "))
for c in range(1, 11):
    soma = dividendo*c
    print("{} x {} = {}".format(dividendo, c,soma))