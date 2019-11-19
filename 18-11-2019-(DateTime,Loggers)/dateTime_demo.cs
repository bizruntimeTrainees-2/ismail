using System;
using System.Globalization;

public class Datetime
  {
	public static void Main()
	{
		var date1 = new DateTime(2019,11,18);
		Console.WriteLine(date1.ToString());
        Console.WriteLine(date1.ToString("F"));
		Console.WriteLine(date1.ToString("F",new System.Globalization.CultureInfo("in-IN")));
	}
}
		