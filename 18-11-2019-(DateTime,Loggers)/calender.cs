using System;
using System.Runtime;
using System.Globalization;


public class Datetime
  {
	public static void Main()
	{
	
		CultureInfo  thTH = CultureInfo.CreateSpecificCulture("th-TH");
		Calendar cd = thTH.Calendar;
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
	