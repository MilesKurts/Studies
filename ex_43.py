peso = float(input("Qual o seu peso? "))
altura = float(input("Qual sua altura? "))
imc = peso / altura**2
print("IMC:{}".format(imc))
if imc <18.5:
    print("você esta abaixo do peso")
elif imc <25:
    print("Peso normal!")
elif imc <30:
    print("Sobre peso")
elif imc <40:
    print("Obesidade")
elif imc>= 40:
    print("Obesidade morbida!")