
using System;

namespace SampleApp {
   public delegate string MyDel(string str);
	
  public  class EventProgram {
      event MyDel MyEvent;
		
      public EventProgram() {
         this.MyEvent += new MyDel(this.WelcomeUser);
      }
      public string WelcomeUser(string username) {
         return "Hello " + username;
      }
     public static void Main(string[] args) {
         EventProgram obj1 = new EventProgram();
         string result = obj1.MyEvent("To All");
        Console.WriteLine(result);
      }
   }
}