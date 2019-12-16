using System;
using System.Runtime;

using System.Globalization;


public class Datetime
  {
	public static void Main()
	{
		DateTimeOffset dateOffSet1, dateOffSet2;
		TimeSpan difference;
		dateOffSet1 = DateTime.Now;
		dateOffSet2 = DateTime.UtcNow;
		difference = dateOffSet1 - dateOffSet2;
		Console.WriteLine("DateTime: "+ dateOffSet1.ToString()+ "   "+dateOffSet2.ToString());
		Console.WriteLine("TimeSpan: "+ difference.ToString());
	}
}
		