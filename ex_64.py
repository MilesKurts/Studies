num = cont = soma =0
while num != 999:
    soma += num
    cont += 1
    num = int(input("Digite um numero[999 para parar] "))

print("Voce digitou {} numeros e a soma é {}.".format(cont, soma))
