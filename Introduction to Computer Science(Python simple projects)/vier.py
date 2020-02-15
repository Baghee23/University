#define every "written" number in a function that returns the number as an integer
def zero():
        k = 0
        return int(k)
def one():
        k=1
        return int(k)
def two():
        k=2
        return int(k)
def three():
        k=3
        return int(k)
def four():
        k=4
        return int(k)
def five():
        k=5
        return int(k)
def six():
        k=6
        return int(k)
def seven():
        k=7
        return int(k)
def eight():
        k=8
        return int(k)
def nine():
        k=9
        return int(k)
#define all the calculations asked,as functions and input the two numbers given by the user
def plus(x,y):
    print (x + y)

def times(x,y):
    print (x * y)

def minus(x,y):
    print (x - y)
#input the calculate given in text with raw_input just to make sure that only str types can be inserted
text1 = raw_input("Insert the calculation you'd like to make between two numbers:")
#split the str based on the "(" in order to decode the string into numbers and calculation
text2= text1.split("(")
#construct a list with "written" numbers to match them to the string given
textList=['zero','one','two','three','four','five','six','seven','eight','nine']
#construct a list filled with the functions in order to call them right after the matching amongst strings and textList
sqList=[zero(),one(),two(),three(),four(),five(),six(),seven(),eight(),nine()]
#Using "for" loops to match the content of textList to the strings
for i in range(0,10):
    if (textList[i] == text2[0]):
        x=sqList[i]
for i in range(0,10):
    if (textList[i] == text2[2]):
        y=sqList[i]
#directly match the calculation string to the function needed to execute the calculation
if  (text2[1]=='plus'):
     plus(x,y)
elif (text2[1] == 'times'):
     times(x,y)
elif (text2[1] == 'minus'):
     minus(x,y)
