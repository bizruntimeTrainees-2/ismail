using System;

public class Datetime
{
     public static void Main(string[] args)
	 {
		 DateTime  thisTime = DateTime.Now;
		 TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("China Standard Time");
		 DateTime tziTime = TimeZoneInfo.ConvertTime(thisTime,TimeZoneInfo.Local,tzi);
		 Console.WriteLine("This time in {0} is {1}",tzi.IsDaylightSavingTime(tziTime)? tzi.DaylightName:tzi.StandardName,tziTime);
		 Console.WriteLine("UTC  time {0} :",TimeZoneInfo.ConvertTimeToUtc(tziTime,tzi));
	 }
}