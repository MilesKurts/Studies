listanum = []
mai = 0
men = 0
for c in range(0,5):
    listanum.append(int(input(f"digite o valor para a posição {c}: ")))
    if c  == 0:
        mai = men =listanum[c]
    else:
        if listanum[c]>mai:
            mai = listanum[c]
        if listanum[c]< men:
            men = listanum[c]

print("=-=-"*15)
print(f"voce digitou os valores {listanum}")
print(f"o maior numero digitado foi o {mai}  nas posições ")
for i, v in enumerate(listanum):
    if listanum[i]==mai:
        print(f"{i}")
print(f"e o menor foi o {men}, nas posições ")
for i, v in enumerate(listanum):
    if listanum[i]==men:
        print(f"{i}")
