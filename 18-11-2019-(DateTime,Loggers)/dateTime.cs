using System;
using System.Globalization;

public class Datetime
  {
	public static void Main()
	{
		string[] formats = {"ddMMyyyy","HHmmss"};
		string[] dates = {"10-11-2019","15-11-2019","20-11-2019","10:10:10","11:11:11","12:12:12"};
		DateTime parsedDate;
		foreach(var date1 in dates)
		{
			if(DateTime.TryParseExact(dates.ToString(), formats.ToString(), null, 
									  System.Globalization.DateTimeStyles.AllowWhiteSpaces |
									 System.Globalization.DateTimeStyles.AdjustToUniversal, out parsedDate))
			   {
				   Console.WriteLine(date1, parsedDate);
			   }
			else
				Console.WriteLine("cannot converted: "+date1);
			   
		}
	}
}
		