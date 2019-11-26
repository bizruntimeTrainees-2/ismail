using System;
using System.Collections.Generic;
public class Collections1
{
	
    public static void Main(string[] args)
    {
        Stack<string> st = new Stack<string>();
        st.Push(" xmen");
        st.Push("spider");
        st.Push(" jackson");
         Console.WriteLine(st.Peek().ToString().Trim()); //read the last element
		Console.WriteLine(st.Pop().ToString().Trim());//remove last element
        foreach(var s in st)
        {
            Console.Write(s.Trim() +",");
        }
	}
}

