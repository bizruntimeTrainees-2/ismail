?using System;
using System.Threading.Tasks;

namespace AsyncExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalAfterTax = CalculateTotalAfterTaxAsync(70);
            DoSomethingSynchronous();

            totalAfterTax.Wait();
            Console.WriteLine("Done");
        }

        private static void DoSomethingSynchronous()
        {
            Console.WriteLine("Doing some synchronous work");
        }

        static async Task<float> CalculateTotalAfterTaxAsync(float value)
        {
            Console.WriteLine("Started CPU Bound asynchronous task on a background thread");
            var result = await Task.Run(() => value * 1.2f);
            Console.WriteLine($"Finished Task. Total of Rs.{value} after tax of 20% is Rs.{result} ");
            return result;
        }
    }
}