vel = float(input("How much km are you riding?"))
charge = float((vel - 80)*7)
if vel <= 80:
    print("No charge")
else:
    print("Your charge is {}".format(charge))
print("Have a good day!")