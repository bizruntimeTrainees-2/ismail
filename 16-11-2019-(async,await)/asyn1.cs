using System;
using System.Threading.Tasks;

public class Class1
{
    public static void Main()
    {
        GetTodayInfo().Wait();
    }
     static async Task GetTodayInfo()
    {
        await WaitAndApology();
       Console.WriteLine("Today is :"+DateTime.Today + 
           "\n Today time is: " + DateTime.Now.TimeOfDay);
        
    }
    static async  Task  WaitAndApology()
    {
        await Task.Delay(2000);
        Console.WriteLine("Sory for the delay");
    }

}
