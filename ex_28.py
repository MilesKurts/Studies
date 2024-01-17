import random
n = random.choice([0,5])
c = int(input("CHOOSE A NUMBER BETWEEN 0 AND 5: "))
if c == n:
    print("Congratulation!")
elif c >= 6:
    print("ERROR")
elif c != n:
    print("Wrong!")
