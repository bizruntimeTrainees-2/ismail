using System;
namespace Data{
delegate void Del(int i, int j);
public class Dell
{
    public static void Main()
    {
        
        Dell d = new Dell();
        Del de = d.Method;

        for (int i = 0; i < 5 ; i ++ )
        {
            de(i, i);
        }
}
public void Method(int i, int j)
 {
    Console.WriteLine(i +j);
}
}
}