# -*- coding: utf-8 -*-
"""

@author: MARCOS
"""

def fibonacci(count): 
    lista = [0, 1] 
    any(map(lambda _: 
            lista.append(sum(lista[-2:])), 
            range(2, count))) 
    
     return lista[:count] 
  
n = int(input("Introduzca un numero: ")) 
 
print(fibonacci(n)) 
