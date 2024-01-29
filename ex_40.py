n1 = float(input("primeira nota: "))
n2 = float(input("segunda nota: "))
m = (n1 + n2) /2
if m>=5 and m <= 7:
    print("passou!")
elif m <= 5:
    print("reprovou!")
elif m >= 7.1:
    print("passou bem!")