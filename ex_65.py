p = "S"
media = soma= quant = maior = menor = 0
while p in "Ss":
    num = int(input("Digite um numero: "))
    quant += 1
    soma += num
    if quant == 1:
        maior = menor =num
    else:
        if num >maior:
            maior = num
        if num < menor:
            menor = num
    p = str(input("Quer digitar um numero? (N/S)")).strip().upper()
media = soma /quant
print(" Foram {} numeros e a media foi {}".format(quant, media))
print("{} foi o maior e {} foi o menor".format(maior, menor))