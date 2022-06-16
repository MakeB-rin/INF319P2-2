// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.
open System

printfn "\nFibonacci Recursivo"

let rec fib n = if n > 1 then fib(n-1) + fib(n-2) else n
[1..10] |> Seq.iter(fun n -> 
    printf "%d "  (fib(n-1)))


[<EntryPoint>]
let main argv = 
    printfn "%A" argv

    let tecla =Console.ReadKey()
    0 // devolver un código de salida entero
