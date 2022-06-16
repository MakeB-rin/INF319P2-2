object fibonacci {

  def fsuperior(funcion:Int=>Int):Unit= {
	println (funcion(n))
	}
  
  def fibonacci(n: Int): Int = {
    if ( n == 0 ) 0
    else if ( n == 1 ) 1
    else fibonacci( n-1 ) + fibonacci( n-2 )

  }

  def main(args: Array[String]): Unit =
  
  println("Dame un valor n: ")
   val n =scala.io.StdIn.readInt()
   println("Fibonacci Recursivo")
   var x = 0;
   while( x < n ){
	 fsuperior(fibonacci(x))
	 x = x + 1
	 }

}