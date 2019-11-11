using System;
public class E4
{
    public static void Main(string[] args)
    {
        try
        {
          
		  
			String s = null;
			Console.WriteLine(s.Length);
            Console.WriteLine("from try block"); // this stmt won't execute
        }
		
        catch (NullReferenceException ex)
        {
            Console.WriteLine("exception handle here : " + ex);
        }
		finally
		{
          Console.WriteLine("last stmt from finally");
		}
    }
}