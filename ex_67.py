while True:
    print("-"*45)
    t = int(input("Do you want to see a multiplication table? "))
    if t < 0:
        print("Getting finished...")
        break
    n = 0
    while n <10:
        n+=1
        print(f"{t} x {n} = {t*n}")
print("Thanks, have a good day!")