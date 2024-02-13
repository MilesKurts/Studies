m20 = h = p18 = 0
while True:
    i = int(input("Qual a idade da pessoa? "))
    if i >= 18:
        p18 +=1
    s = " "
    while s not in "MF":
        s = str(input("Qual o sexo da pessoa? (M/F)")).strip().upper()[0]
    if s in "Ff" and i > 20:
        m20 +=1
    elif s in "Mm":
        h +=1
    else:
        pass
    c = " "
    while c not in "SN":      
        c = str(input("Quer continuar? (S/N)")).strip().upper()[0]
    if c in "Nn":
        break
    else:
        pass
print(f"AQUI TEMOS {m20} mulher(es) com mais de 20 anos, {h} homem(ns) e {p18} pessoas com mais de 18 anos")