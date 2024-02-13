print("-=-="*10)
print("Bem vindo ao super mercado!!")
print("-=-="*10)
total = totmil = menor = cont=0
barato = " "
while True:
    produto = str(input("Nome do produto: "))
    preço = float(input("Qual o preço?"))
    
    total += preço
    if preço > 1000:
        totmil += 1
    if cont == 1 or preço < menor:
        menor = preço
        barato = produto
    cont += 1
    resp = " "
    while resp not in "SN":
        resp = str(input("Quer continuar? [S/N]")).strip().upper()[0]
    if resp == "N":
        break
print("FIM!")
print(f"sua compra ficou {total} e {totmil} produto(s) foram mais de 1000 reais e o produto mais barato custa {menor} e foi a(o) {produto}!")