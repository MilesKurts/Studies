name = str(input("What's your name? "))
if name == "Miles":
    print("What a beatiful name!")
elif name == "Grazi":
    print("You're beatiful!")
elif name in "Ana Claudia Jessica Juliana":
    print("Nome feminino!")
else:
    print("You good a normal name!")
print("You Have a good day, {}!".format(name))