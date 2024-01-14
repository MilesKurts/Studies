frase = str(input('Insert a sentence: \n')).upper()
print('A letra A aparece {} vezes na frase!'.format(frase.count('A')))
print('A primeira letra a esta {}'.format(frase.find('A')+1))
print('A ultima letra a esta {}'.format(frase.rfind('A')+1))

