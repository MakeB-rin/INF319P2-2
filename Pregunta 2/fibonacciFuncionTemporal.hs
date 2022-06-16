--Fibonacci Recursivo
fib :: Integer -> Integer
fib 0 = 0
fib 1 = 1
fib 2 = 1
fib n = fib (n-1) + fib (n-2)

fibonacci :: Integer -> Integer -> String
fibonacci n c =
  if n < c then
    show (fib n) ++ " " ++ fibonacci (succ n) c
  else
    show (fib n-1) 

main :: IO()
main = do
  putStrLn "Fibonacci"
  print(fibonacci 0 12)