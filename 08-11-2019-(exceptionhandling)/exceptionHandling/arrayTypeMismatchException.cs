using System;
public class E5
{
    public static void Main(string[] args)
    {
        try
        {
           string[] array1 = { "cat", "dog", "fish" };
             object[] array2 = array1;
            
			Console.WriteLine(array2[0] = "house");
			Console.WriteLine(array2[0] = 10);            // this gives arrayMismatch ex

            Console.WriteLine("from try block"); // this stmt won't execute
        }
		
        catch (ArrayTypeMismatchException ex)
        {
            Console.WriteLine("exception handle here : " + ex);
        }
		finally
		{
          Console.WriteLine("last stmt from finally");
		}
    }
}