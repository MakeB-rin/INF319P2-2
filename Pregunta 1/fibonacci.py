# -*- coding: utf-8 -*-
"""
@author: MARCOS
"""
#Fibonacci Estructural
def fibonacci(n):
    a = 1
    b = 1
    
    if n==1:
        print('0', end=' ')
    elif n==2:
        print('0', end=' ')
        print('1', end=' ')
        
    else:
        print('0', end=' ')
        print(a, end=' ')
        print(b, end=' ')
        
        for i in range(n-3):
            total = a + b
            b = a
            a = total
            print(total, end=' ' )
          
n = int(input("Introduzca un numero "))
                     
fibonacci(n)
print("\n")

#Fibonacci Recursivo
def rec_fib(n):
    if n==1:
        return 1
    elif n==2:
        return 1
    elif n==0:
        return 0
    else:
        return rec_fib(n-1) + rec_fib(n-2)
    
        
for i in range(n):
    print(rec_fib(i), end=' ')
     