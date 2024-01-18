x = float(input("Insert a triangular side: "))
z = float(input("Insert a triangular side: "))
y = float(input("Insert a triangular side: "))
mai = y
men = z + x
if x > z and x > y:
    mai = x
    men = z+y
elif z > x and z > y:
    mai = z
    men = x+y
else:
    pass
# finaly
if mai >= men:
    print("It couldn't be a triang")
else:
    print("It can be")