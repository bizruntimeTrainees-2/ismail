using System;
using System.Runtime;
using System.Globalization;

public class Datetime
  {
	public static void Main()
	{
		string displayName = "(GMT +05:00) England/London";
		string standardName = "London";
		TimeSpan offset = new TimeSpan(05,00,00);
		TimeZoneInfo  london = TimeZoneInfo.CreateCustomTimeZone(standardName, offset, displayName, standardName);
		Console.WriteLine("the current time is {0}{1}", TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, london), london.StandardName);
				
	}
  //  public static TimeZoneInfo CreateCustomTimeZone (string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName);
}
	