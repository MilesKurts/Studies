#import random
#n = random.choice([0,5])
#c = int(input("CHOOSE A NUMBER BETWEEN 0 AND 5: "))
#if c == n:
#    print("Congratulation!")
#elif c >= 6:
#    print("ERROR")
#elif c != n:
#    print("Wrong!")

from random import randint
comp =randint(0,5)
print('-=-'*20)
print('Thinking about a number... try me: ')
jog = int(input("What one i choose? "))
if jog == comp:
    print('perfect')
else:
    print("wrong!")