print("=-=-" * 14)
print("Sequencia de fibonacci")
print("=-=-" * 14)
n =  int(input("Quantos termos voce quer mostrar? "))
t1 = 0
t2 = 1
print("~"*57)
print("{} -> {}".format(t1, t2), end=" -> ")
c = 3
while c <=n:
    c += 1
    t3 = t1 + t2
    print("{}".format(t3), end=" -> ")
    t1 = t2
    t2 =t3
print("FIM")