--Fibonacci
fib :: Int -> Int
fib 0 = 0
fib 1 = 1
fib 2 = 1
fib n = fib (n - 1) + fib (n - 2)

iteracion         ::  (a -> b) -> [a] -> [b]
iteracion _ []     =  []
iteracion f (x:s)  =  f x : iteracion f s

main :: IO()
main = do
  putStrLn "Fibonacci"
  print(iteracion fib[0..12] )