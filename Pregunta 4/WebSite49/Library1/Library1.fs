namespace Library1
open System

//Fibonacci 
module fib =
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
                printf "%d "  c
                a <- b
                b <- c
            b


//Fibonacci Recursivo
module fibR =
    let rec fiboR =
      function 
      | 0 -> 0
      | 1 -> 1
      | 2 -> 1
      | n -> fiboR (n-1) + fiboR (n-2)

  
    let rango = [0..10]
    Console.WriteLine("\n\nFibonacci Recursivo\n")
    for i in rango do
       printf "%d " (fiboR i)


type Class1() = 
    member this.X = "F#"
    
