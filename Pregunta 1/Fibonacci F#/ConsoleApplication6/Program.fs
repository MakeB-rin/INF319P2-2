// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.

open System

//Fibonacci 

let fibo n = 
    match n with 
    | 0 -> 0
    | 1 -> 1
    | 2 -> 1
    | n -> 
        let mutable a = 0
        let mutable b = 1
        for i in 1 .. (n - 1) do
            let c = a + b
            a <- b
            b <- c
        b
//Fibonacci Recursivo

let rec fiboR =
  function 
  | 0 -> 0
  | 1 -> 1
  | 2 -> 1
  | n -> fiboR (n-1) + fiboR (n-2)


[<EntryPoint>]
let main argv = 
    
    let rango = [0..10]
    
    Console.WriteLine("Fibonacci\n")  
    for i in rango do
        printf "%d "  (fibo i)

    Console.WriteLine("\n\nFibonacci Recursivo\n")

    for i in rango do
        printf "%d " (fiboR i)

    let tecla = Console.ReadKey()
    0 // devolver un código de salida entero


