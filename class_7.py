# 5 + 2 == 7
# 5 - 2 == 3
# 5 * 2 == 10
# 5 / 2 == 2.5
# 5 ** 2 == 25
# 5 // 2 == 2
# 5 % 2 == 1

# 1 - ();
# 2 - **;
# 3 - *, /, //, %; 
# 4 - +, -.

# nome = input('Qual é seu nome? ')
# print("prazer em te conhecer {:^20}".format(nome))

n1 = int(input('a value: '))
n2 = int(input('another number: '))
s = n1 + n2
m = n1 * n2
d = n1 / n2
di = n1 // n2
e = n1 ** n2
print('the sum is {}, the product is {} and the division is {}'.format(s, m, d), end=" ")
print('the int division is {} and the pow is {}'.format(di, e))
