# -*- coding: utf-8 -*-
"""
@author: MARCOS
"""

def comprobar (n):
    if n==1:
        return 1
    elif n==2:
        return 1
    elif n==0:
        return 0
    else:
        return n
    
    
def rec_fib(n):
    if n<2:
        return n
    else:
        return rec_fib(n-1) + rec_fib(n-2)
    
    
    
n = int(input("Introduzca un numero: "))   

for i in range(n):
    print(rec_fib(comprobar(i)), end=' ')