using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch=true)]
namespace loggers
{
    public class Class1
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);//Loghelper.GetLogger(); 
        public static void Main(string[] args)
        {
            {
                Console.WriteLine("Hello world");

                log.Error("this is my error message");
                Console.ReadLine();
            }
        }
    }
}
