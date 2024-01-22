n1 = int(input("Type a number: "))
n2 = int(input("Type another one: "))
if n1 > n2:
    print("{} is the bigger".format(n1))
elif n2 > n1:
    print("{} is the bigger".format(n2))
else:
    print("They are equal")