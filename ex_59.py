n1 =  int(input("Primeiro numero: "))
n2 = int(input("Segundo valor "))
op = 0
while op != 5:
    print('''       [ 1 ] Somar
        [ 2 ] multiplicar
        [ 3 ] maior
        [ 4 ] novos numeros
        [ 5 ] sair do programa''')
    op = int(input("Qual é a sua opção?"))
    if op == 1:
        soma = n1 +n2
        print(soma)
    elif op == 2:
        mul = n1 * n2
        print(mul)
    elif op == 3:
        if n1 > n2:
            print(n1)
        elif n1 < n2:
            print(n2)
        elif n1 == n2:
            print("São iguais")
    elif op == 4:
        pass
    elif op == 5:
        print("saindo")
    else:
        print("Opção invalida. tente novamente")
    print("=-="*10)

print("Fim do programa!")
  