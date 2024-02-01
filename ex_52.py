num = int(input("Digite um numero: "))
tot = 0
for c in range(1, num+1):
    if num % c == 0:
        print("\33[34m", end=" - ")
        tot +=1
    else:
        print("\33[31m", end=" - ")
    print("{} ".format(c))
print("O numero {} foi divisivel {} vezes ".format(c,tot), end="  ")
if tot == 2:
    print("Ele é um numero primo")
else:
    print("Ele não é numero primo!")