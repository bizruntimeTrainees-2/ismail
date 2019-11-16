using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

public class Class1
{
    public static void Main()
    {
        Console.WriteLine(GetTodayInfo().Result);
    }
     static async Task<string> GetTodayInfo()
    {
        string  str =  "Today is :"+DateTime.Today + " " + DateTime.Now.TimeOfDay +"Today hours of leisture:" + await GetLeistureHours();
        return str;
    }
    static async  Task<int> GetLeistureHours()
    {
        var date = await Task.FromResult<string>(DateTime.Now.DayOfWeek.ToString());

        int hours;
        if (date.First() == 'S')
        {
            hours = 16;
        }
        else
            hours = 5;
        return hours;
    }

}
