from random import randint
print("=-=-"*5)
print("Let's play odd or even?")
print("=-=-"*10)
v = 0
while True:
    player = int(input("Type a value: "))
    pc = randint(0,11)
    total = player+pc
    tipo = " "
    while tipo not in "PI":
            tipo = str(input("Par ou impar: ")).strip().upper()[0]
    print(f"You choose {player} and the pc played {pc}. the sum is {total}")
    if tipo == "P":
        if total % 2 == 0:
            print("WIN!")
            v +=1
        else:
            if total % 2 == 1:
                print(" Lose!")
                break
    elif tipo == "I":
        if total % 2 == 1:
              print("Win!")
              v +=1
        else:
             print("LOSE!")
             break
    print("Let's play again...")
print(f"Game over! You win {v} times")