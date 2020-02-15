def maxSequence(lista):
#Calculate the length of the given list
    lilen=len(lista)
#Initialize the variables to start the search of the biggest sum amongst the sequences of the given list
    max=0
    p=0
    a=0
#Loop needed to access in every cell of the list in order to check all possible sequences and sums
    for i in range(0,lilen-1):
        for j in range(i+1,lilen):
#Compare the sum of the sequence to the maximum sum found
            if sum(lista[i:j])>max:
#Store the indexes which give the max sum
                p=i
                a=j
#Store the max sum of the list
                max=sum(lista[i:j])
    mlista=lista[p:a]
    return mlista
#Input a list of numbers given by the user
lista=input("Give the list you'd like to test my code on:")
#Output of maxSequence function
result=maxSequence(lista)
#Print the results as asked from Mr.Patsakis :)
print sum(result),":",result
