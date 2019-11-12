using System;
public class E2
{
    public static void Main(string[] args)
    {
        try
        {
		    int[] arr = {1,2};
			Console.WriteLine(arr[2]);
            Console.WriteLine("from try block"); // this stmt won't execute
        }
		
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("exception handle here : " + ex);
        }
		finally
		{
          Console.WriteLine("last stmt from finally");
		}
    }
}