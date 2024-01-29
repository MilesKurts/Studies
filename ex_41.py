from datetime import date
year = int(input("que ano voce nasceu"))
atual = date.today().year
age = atual - year
if age <=9:
    print("voce é da categoria mirim!")
elif age <=14:
    print("voce é da categoria infantil!")
elif age <=19:
    print("você é da categoria junior!")
elif age <= 25:
    print("voce é da categoria senior")
else:
    print("voce é da categoria master!")
