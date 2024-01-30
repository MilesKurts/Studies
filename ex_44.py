preco = float(input("Qual o valor do produto? "))
print('-'*30)
print("Formas de pagamento:")
print('-'*30)
print("1- A vista no dinheiro(10% de desconto!)")
print("2- A vista no cartão(5% de desconto!)")
print("3- No cartão em duas vezes(Preço normal!)")
print("4- 3 vezes no cartão(20% de juros!)")
formaPag = int(input("Qual a forma de pagamento? "))
if formaPag == 1:
    valorFin = preco - (preco*10/100)
    print("O valor a ser pago sera de {} com 10% de desconto.".format(valorFin))
elif formaPag == 2:
    valorFin = preco - (preco*5/100)
    print("O valor a ser pago sera de {} com 5% de desconto.".format(valorFin))
elif formaPag == 3:
    valorFin = preco
    print("O valor a ser pago sera de {} sem desconto.".format(valorFin))
elif formaPag == 4:
    valorFin = preco + (preco*20/100)
    print("O valor a ser pago se de {} com 20% de juros".format(valorFin))
else:
    print("Error")