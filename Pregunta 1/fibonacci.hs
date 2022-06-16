--Fibonacci Recursivo
fibo :: Int -> Int
fibo 0 = 0
fibo 1 = 1
fibo 2 = 1
fibo n = (fibo (n-1)) + (fibo (n-2))

fiboR = map fibo [0..10]

main :: IO()
main = do
  putStrLn "Fibonacci Recursivo"
  print(fiboR)
  --Fibonacci Estructural 
  putStrLn "Fibonacci Estructural"
  print $ map fiboN [0..10]

fiboN 0 = 0
fiboN 1 = 1
fiboN 2 = 1
fiboN n = iter 0 1 n where
    iter a b 2 = a + b
    iter a b n = iter b (a + b) (n - 1)  
  
  
  
