#import the "random" function in order to use it when needed
import random
#using "open" function in order to get the content of the txt file
p=open("uselessarch.txt","r")
if p.mode == 'r':
    useless=p.read()
#include all symbols into a var in order to ger rid of them and get the words as asked
    symbols= '''!()-[]{};:'"\,<>./?@#$%^&*_~'''
#initialize "text" var to store the text without symbols into it
    text = ""
    for char in useless:
        if char not in symbols:
#get only the words from the txt
            text= text + char
#split the text var through " " in order to get every single word saved in a list
    text2=text.split(" ")
    te2len= len(text2)
    text3=[]
    for i in range(0,te2len-2):
#construct direct indexes in order to get every possible 3 consecutive words with coating
            k= text2[i]
            l= text2[i+1]
            m= text2[i+2]
            n=k + " "+ l + " "+m
            text3.append(n)
#randomize the place of every single word to generate a new text based on the one given
    random.shuffle(text3)
    text4=' '.join(text3)
    print text4
