d = int(input('How much days are you hiring?\n'))
t = float(input("How much Km did you run?\n"))
r = (d * 60) + (t * 0.15)
print("You will have to pay R${} US dolars".format(r))
