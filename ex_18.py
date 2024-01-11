import math
angulo = float(input('Insert an Angle:\n'))
seno = math.sin(math.radians(angulo))
cosseno = math.cos(math.radians(angulo))
tangente = math.tan(math.radians(angulo))
print('O angulo de {:.2f} tem Tangente {:.2f},cosseno {:.2f}, seno {:.2f}'.format(angulo,tangente,cosseno,seno))