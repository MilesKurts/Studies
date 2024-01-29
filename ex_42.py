x = float(input("Insert a triangular side: "))
z = float(input("Insert a triangular side: "))
y = float(input("Insert a triangular side: "))

if x < z + y and z < x +y and y<z+x:
    print("Pode ser um triangulo! ")
    if z == x==y:
        print("EQUILATERO")
    elif z != x != y !=z:
        print("Escaleno")
    else:
        print("ISOSCELES")
elif z =="":
        print("error")
elif y =="":
        print("error")
elif x =="":
        print("error")
else:
    print("Não pode ser um triangulo!")
