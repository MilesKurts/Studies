num = int(input("Insert a int number: "))
print('''Choose a base to convert:
      [1] convert to binary
      [2] convert to octal 
      [3] convert to hexadecimal''')
op = int(input("Your option: "))
if op == 1:
    print("{}".format(bin(num)[2:]))
elif op == 2:
    print(oct(num[2:]))
elif op == 3:
    print(hex(num[2:]))
else:
    print("ERROR")