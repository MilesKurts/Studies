import math
co = float(input('Comprimento do cateto oposto'))
ca = float(input('comprimento do cateto adjacente:'))
#hi = (co ** 2 + ca ** 2 )**(1/2)
hi = math.hypot(co, ca)
print("A hipoternusa vai medir {:.2f}".format(hi))