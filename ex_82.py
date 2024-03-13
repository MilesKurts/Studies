num = list()
pares = list()
impares = list()
while True:
    num.append(int(input("Digite um numero: ")))
    resp =  str(input("Quer Continuar? [S/N]"))
    if resp in "Nn":
        break
for i, v in enumerate(num):
    if v %2 == 0:
        pares.append(v)
    elif v % 2 == 1:
        impares.append(v)
print("-=-="*15)
print(f"A lista completa é {num}")
print(f"Alista de pares é {pares}")
print(F"a LISTA DE IMPARES É {impares}")