using System;

namespace UserException
{
    public class MyException : Exception
    {
        public MyException()
        {
            Console.WriteLine("something went wrong");
        }
        public MyException(string str)
        {
            Console.WriteLine("invalid string");
        }
    }
    public class NewException
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter something");
                string s = Console.ReadLine();
                int a = Convert.ToInt32(s);
                if (a == 0)
                {
                    throw new MyException();
                }
                if (a > 10)
                {
                    throw new MyException("str");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("exception handle here : " + e);
            }
        }
    }
}