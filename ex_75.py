num = (int(input("Digite um numero: ")),int(input("Digite outro numero: ")), int(input("Digite mais um numero: ")), int(input("Digite o ultimo numero: ")))
print(f'voce digitou os valores {num}')
print(f'O valor nove apareceu {num.count(9)}')
if 3 in num:
    print(f'O valor 3 apareceu na {num.index(3)} posição')
else:
    print(f'O valor 3 nao apareceu em nenhuma posição')
p = 0
for n in num:
    if n % 2 ==0:
        p +=1
print(f'Aparecederam {p} numeros pares')
