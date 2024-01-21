house = float(input("How much is the house? "))
salary = float(input("What's your salary? "))
years_paying = int(input("How much years are you paying?"))
times = house/(years_paying*12)
min = salary * 30/100
print("Para pagar uma casa de R${:.2f} em {} anos".format(house,years_paying) )
print(" a prestação será de R${:.2f}".format(times))
if times <= min:
    print("OK")
else:
    print("NOT OK")