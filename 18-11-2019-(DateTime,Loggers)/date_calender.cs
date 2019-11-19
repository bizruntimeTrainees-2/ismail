using System;
using System.Runtime;
using System.Globalization;


public class Datetime
  {
	public static void Main()
	{
	
		CultureInfo  jpJP = CultureInfo.CreateSpecificCulture("jp-JP");
		Calendar cd = jpJP.Calendar;
		Console.WriteLine("calender Name : {0}", GetCalenderName(cd));
		if (cd is GregorianCalendar)
         Console.WriteLine(" ({0})", 
                           ((GregorianCalendar) cd).CalendarType);
      else
         Console.WriteLine();
		DateTime date1 = new DateTime(2019, 11, 18);   
      Console.WriteLine("Date: {0:d}", date1);
      Console.WriteLine("Date in the Invariant Culture: {0}", 
                        date1.ToString("d", CultureInfo.InvariantCulture));
      Console.WriteLine();
		
	}
	static string GetCalenderName(Calendar cal)
   {
      return cal.ToString().Replace("System.Globalization.", "");
   }
}
	