year = int(input("What year are you analising? "))
if year % 4 == 0 and year % 100 != 0 or year % 400 == 0:
    print("The year {} is bisex".format(year))
else:
    print("The year {} is not".format(year))