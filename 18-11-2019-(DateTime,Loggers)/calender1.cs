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
		
	}
	static string GetCalenderName(Calendar cal)
   {
      return cal.ToString().Replace("System.Globalization.", "");
   }
}
	