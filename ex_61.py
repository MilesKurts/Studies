c = 0
n1 = int(input("primeiro termo: "))
n2 = int(input("Razão PA: "))
while c < 10:
    print(n1, end=" -> ")
    c +=1
    n1 += n2
print("FIM")