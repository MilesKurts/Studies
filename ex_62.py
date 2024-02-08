n1 = int(input("primeiro termo: "))
n2 = int(input("Razão PA: "))
termo = n1
cont = 1
total = 0
mais = 10
while mais != 0:
    total = total + mais
    while cont <= total:
        print("{} -> ".format(termo), end=" ")
        termo +=n2
        cont += 1
    print("PAUSA")
    mais = int(input("Quantos termos quer mostrar a mais?"))
print("{} termos mostrados".format(total))