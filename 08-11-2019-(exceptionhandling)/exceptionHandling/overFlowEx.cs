using System;
public class E6
{
    public static void Main(string[] args)
    {
       int value = 780000000;
     checked{
                        try {
                                 int square = value * value;  //overflow ex
                   	            Console.WriteLine("from try" +  square);
                            }
                      catch (ArithmeticException e)  // this is super cls to overflow exception
                          {
	                           Console.WriteLine("from catch : " + e);
                             } 
		           finally
		               {
                         Console.WriteLine("last stmt from finally");
		               }
              }
    }
}