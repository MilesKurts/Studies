i = s =0
while True:
    n = int(input("Type a number: (999 to stop)"))
    if n == 999:
        break
    s += n
    i += 1
print(f"There was typed {i} number(s), and their sum are {s}")