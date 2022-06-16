object fibonacci {
  val suma =(a:Int , b:Int) => a + b
  println(suma(a,b))
  
  def fibo(n:Int):Unit={
    if(n>0){
     while(i <= n)
      c = suma (a,b);
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
  
  def main(args: Array[String]): Unit =
   
   println("Dame un valor n: ")
   val n =scala.io.StdIn.readInt()
   println("Fibonacci")
   print("0 1" )
   fibo(n-2)
}