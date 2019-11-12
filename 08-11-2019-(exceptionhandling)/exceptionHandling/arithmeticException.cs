using System;
public class E1
{
    public static void Main()
    {
        try
        {
            int  a = 0;
            int b = 10/a;
            Console.WriteLine("from try block"); // this stmt won't execute
        }
        catch (DivideByZeroException ex) // this is sub cls to Arithmetic exception
        {
            Console.WriteLine("exception handle here : " + ex);
        }
		finally
		{
          Console.WriteLine("last stmt from finally");
		}
    }
}