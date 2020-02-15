list=input("Give the list you'd like to test my code on(yeap I'm not very creative):")
def sumIntervals(list):
    lilen=len(list)
#construct two empty lists that will be filled with the content of the list
    a=[]
    b=[]
#construct a new list "t" just to save the first content of the input list
    t=list[0]
#calculate the distance of the first list in the input list
    sr=t[1]-t[0]
    for i in range(0,lilen):
        t=list[i]
#get all the indexes-content in two separated lists
        a.append(t[0])
        b.append(t[1])
    for i in range(1,lilen):
            t=list[i]
#calculate the maximum inferior limit in p1 based on "i" price
            p1=max(a[0:i])
#calculate the minimum upper limit in p2 based on "i" price
            p2=min(b[0:i])
#compare the given list content of the input list in order to calculate everything once
            if t[1]>p2 and (t[0]<p2 or t[0]==p2):
                sr=sr+ t[1]-p2
            elif t[1]>p2 and (t[0]>p1 or t[1]==p1):
                sr=sr+ t[1]-t[0]
            if sr>max(b):
                sr=sr-p2

    return sr
#MAGIC!
x=sumIntervals(list)
print "The sum is:",x
