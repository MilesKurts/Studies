pt = int(input("Digite o primeiro termo: "))
r = int(input("Digite a razão: "))
dc= pt +(10-1)* r
for c in range(pt, dc+r, r):
    print("{} ".format(c), end=" - ")
print("Acabou")