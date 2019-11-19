using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch=true)]
namespace Loggers
{
    public class LoggersC
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);//Loghelper.GetLogger(); 
        public static void Main(string[] args)
        {
            
                log.Debug("Developer: this is Debugging response error");
                log.Info("Maintenace: This is just information");
                log.Warn("Maintenace: this is Warning error");
                log.Error("Depend: this is my error message");
                log.Fatal("Data: this is serious fatal error");

              var i = 0;
            try
            {
                var x = 0 / i;
            }
            catch(DivideByZeroException ex)
            {
                log.Error("Developer: we tried divide by zero again" + ex);
            }
                  
                Console.ReadLine();
            
        }
    }
}
