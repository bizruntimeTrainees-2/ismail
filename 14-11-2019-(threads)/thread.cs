using System;  
using System.Threading;  
  
public class MyThread  
{  
    public static void Thread1()  
    {  
        Console.WriteLine("hello from thread1");  
    }  
    public  void Thread2()  
    {  
        Console.WriteLine("hello from thread2");  
    }  
}  
public class Threads  
{  
    public static void Main()  
    {  
        Thread t1 = new Thread(new ThreadStart(MyThread.Thread1));  
        Thread t2 = new Thread(new ThreadStart(new MyThread().Thread2));  
        t1.Start();  
        t2.Start();  
    }  
}  