object fibonacci {
  def fibo(n:Int):Unit={
    if(n>0){
     while(i <= n)
      c = a + b;
      a=b
      b=c
      print(" "+ c )
      i=i+1
    }
  }
  var a = 0
  var b = 1
  var c = 0
  var i = 1 
  
  def fib(x:Int) = {
    var msg= "%d "
    msg.format(fibonacci(x))
  }
  
  def fibonacci(n: Int): Int = {
    if ( n == 0 ) 0
    else if ( n == 1 ) 1
    else fibonacci( n-1 ) + fibonacci( n-2 )

  }

  def main(args: Array[String]): Unit =
   println("Dame un valor n: ")
   val n =scala.io.StdIn.readInt()
   
   println("Fibonacci")
   print("0 1" )
   fibo(n-2)
   println()
   
   println("Fibonacci Recursivo")
   var x = 0;
   while( x < n ){
	 print( fib(x) )
	 x = x + 1
	 }

}