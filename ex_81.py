valores = []
while True:
    valores.append(int(input("Digite um valor: ")))
    resp = str(input("Quer continuar? [s/N] "))
    if resp in "Nn":
        break
print("-=-"*15)
print(f"Voce adicionou {len(valores)} elementos.")
valores.sort(reverse=True)
print(valores)
print(f"Os valores decrescente são {valores}")
if 5 in valores:
    print("O valor 5 faz parte da lista")
else:
    print("O valor 5 não faz parte da lista")
