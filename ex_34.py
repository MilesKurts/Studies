sal = float(input("What's your salary? "))
if sal <= 1250:
    new = sal + (sal*15/100)
    print("Your new salary is {}".format(new))
else:
    new = sal + (sal*10/100)
    print("Your new salary is {}".format(new))
