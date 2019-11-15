using System;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

public class Class1
{
    public static async Task Main()
    {
        await Task.Run(() =>
        {
            int ctr = 0;
            for (ctr = 0; ctr < 100; ctr++)
            { }
            Console.WriteLine("total iterations :" + ctr);
        });
    }
}
