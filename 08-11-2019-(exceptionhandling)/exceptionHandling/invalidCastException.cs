using System;
public class E3
{
    public static void Main(string[] args)
    {
        try
        {
          
		   Object o = new Object();
			String s =(string) o;
            Console.WriteLine("from try block"); // this stmt won't execute
        }
		
        catch (InvalidCastException ex)
        {
            Console.WriteLine("exception handle here : " + ex);
        }
		finally
		{
          Console.WriteLine("last stmt from finally");
		}
    }
}