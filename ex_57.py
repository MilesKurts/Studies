sex = str(input("Qual seu sexo? [M/F]")).strip().upper()[0]
while sex not in "FfMm":
    print("Digite corretamente!")
    sex = str(input("Qual seu sexo? [M/F]")).strip().upper()[0]
print("Sexo {} registrado com sucesso!".format(sex))