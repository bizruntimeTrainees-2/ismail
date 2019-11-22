using System;
using System.IO;

public class BinaryR_W
{
    public static void Main(string[] args)
    {
        WriteBinary();
        ReadBinary();
    }
    static void WriteBinary()
    {
        using(BinaryWriter bWriter = new BinaryWriter(File.Open(File.Mode.Create)))
        {
            bWriter.Write("string");
            bWriter.Write(true);
            bWriter.Write(100);
        }
    }
    static void ReadBinary()
    {
        int i;
        string j;
        bool b;
        using(BinaryReader bReader = new BinaryReader(File.Open(fileName, FileMode.Open)))
        {
            i = bReader.ReadInt32();
			j = bReader.ToString();
			b = bReader.ReadBoolean();
			
              Console.WriteLine("String: "+ j.ToString()); 
                Console.WriteLine("integer :"+i); 
			Console.WriteLine("boolean :"+b);		
		}  
        }
}