using System;
using System.IO;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formaters.Binary;

public class Programm
{
	public static void Main(string [] args)
	{
		public int member1 {get; set;}
		public string member2 { get; set;}
		public string member3 { get; set;}
		public string member4 { get; set;}
		
		public Programm()
		{
			member1 = 11;
			member2 = "Helo to all";
			member3= "this is not serializing ";
			member4 = null;
		}
	Programm obj = new Programm();
	 Console.WriteLine(obj.member1);
	  Console.WriteLine(obj.member2);
	  Console.WriteLine(obj.member3);
	   Console.WriteLine(obj.member4);
	[OnSerializing]
     internal void  OnSerializingMethod(StreamingContent content )
	 {
		 member2 = "this is  modified during serializing";
	 }
	 [OnSerialized]
	 internal void  OnSerializedMethod(StreamingContent content )
	 {
		 member2 = "this is  modified after serializing";
	 }
	[OnDeserializing]
	 internal void  OnDeserializingMethod(StreamingContent content )
	 {
		 member3 = "this value was set during deserializing";
	 }
	 [OnDeserialized]
	 internal void  OnDeserializedMethod(StreamingContent content )
	 {
		 member4 = "this value was set after deserialize";
	 }
	
	   
	   string json = JsonConvert.SerializeObject(obj, Formatting.Intended)
	   
	   Console.WriteLine(obj.member1);
	  Console.WriteLine(obj.member2);
	  Console.WriteLine(obj.member3);
	   Console.WriteLine(obj.member4);
	   
	  obj = JsonConvert.DeserializeObject<Programm>(json);
	  
	   Console.WriteLine(obj.member1);
	  Console.WriteLine(obj.member2);
	  Console.WriteLine(obj.member3);
	   Console.WriteLine(obj.member4);
	   
	}
}