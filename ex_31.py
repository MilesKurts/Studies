km = float(input("Inser a kilometer "))
if km <=200:
    price = km * 0.5
    print("You're gonna pay {}".format(price))
else:
    price =km * 0.45
    print("You're gonna pay {}".format(price))