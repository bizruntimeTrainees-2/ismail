    using System;
    using System.Collections.Generic;
namespace Events
{

    public class CustomEventArgs : EventArgs
    {
        public CustomEventArgs(string s)
        {
            message = s;
        }
        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
    }

  public   class Publisher
    {

        public event EventHandler<CustomEventArgs> RaiseCustomEvent;

        public void DoSomething()
        {
            OnRaiseCustomEvent(new CustomEventArgs("Hello to all"));

        }
        protected virtual void OnRaiseCustomEvent(CustomEventArgs e)
        {
            EventHandler<CustomEventArgs> handler = RaiseCustomEvent;
            if (handler != null)
            {
               
                e.Message += "done now";
                handler(this, e);
            }
        }
    }

 public    class Subscriber
    {
        private string id;
        public Subscriber(string ID, Publisher pub)
        {
            id = ID;
            pub.RaiseCustomEvent += HandleCustomEvent;
        }

        void HandleCustomEvent(object sender, CustomEventArgs e)
        {
            Console.WriteLine(id + " received this message:"+ e.Message);
        }
    }

public    class Program
    {
      public  static void Main(string[] args)
        {
            Publisher pub = new Publisher();
            Subscriber sub1 = new Subscriber("sub1", pub);
            Subscriber sub2 = new Subscriber("sub2", pub);

            pub.DoSomething();

         Console.WriteLine("Press Enter to close this window.");
          Console.ReadLine();

        }
    }
}