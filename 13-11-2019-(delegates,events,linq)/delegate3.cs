using System;
namespace Data
{

public class SampleClass
{
	
    public void InstanceMethod()
    {
        Console.WriteLine("A message from the instance method.");
    }

    static public void StaticMethod()
    {
        Console.WriteLine("A message from the static method.");
    }
}

public class TestSampleClass
{
	 delegate void Del();
    public static void Main()
    {
        var sc = new SampleClass();

        Del d = sc.InstanceMethod;
        d();

        d = SampleClass.StaticMethod;
        d();
    }
}
}