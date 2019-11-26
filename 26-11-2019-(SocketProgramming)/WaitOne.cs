using System;
using System.Threading;

namespace WaitOneClass
{
    public class   WaitOneClass
    {
        static AutoResetEvent autoEvent = new AutoResetEvent(false);
        public static void Main(string[] args)
        {
             Console.WriteLine("Main starting");
             ThreadPool.QueueUserWorkItem(new WaitCallback(Method), autoEvent);
             //wait for work method to signal

             autoEvent.WaitOne();
             Console.WriteLine("Method signalled\nmain ending.");
        }
        static void Method(Object start)
        {
            Console.WriteLine("method started");
            //thread keeping in sleep mode

            Thread.Sleep(new Random().Next(100,2000));

            //signal that work is finished
            Console.WriteLine("Method is ending");
            ((AutoResetEvent)start).Set();
        }
    }
}