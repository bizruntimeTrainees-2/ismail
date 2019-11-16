using System;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
namespace CollectionsSL
{
    public class Sortedlist
    {
		public static void Main()
		{
			
		}
	
       public async Task ProcessWriteMultAsync()  
{  
    string folder = @"C:\Users\ismai\Downloads\Microsoft.SkypeApp_kzf8qxf38zg5c!App\All\";  
    IList<Task> tasks = new List<Task>();  
    IList<FileStream> sourceStreams = new List<FileStream>();  
  
    try  
    {  
        for (int index = 1; index <= 10; index++)  
        {  
            string text = "In file " + index.ToString() + "\r\n";  
  
            string fileName = "thefile" + index.ToString("00") + ".pdf";  
            string filePath = folder + fileName;  
  
            byte[] encodedText = Encoding.Unicode.GetBytes(text);  
  
            FileStream sourceStream = new FileStream(filePath,  
                FileMode.Append, FileAccess.Write, FileShare.None,  
                bufferSize: 4096, useAsync: true);  
  
            Task theTask = sourceStream.WriteAsync(encodedText, 0, encodedText.Length);  
            sourceStreams.Add(sourceStream);  
  
            tasks.Add(theTask);  
        }  
  
        await Task.WhenAll(tasks);  
    }  
  
    finally  
    {  
        foreach (FileStream sourceStream in sourceStreams)  
        {  
            sourceStream.Close();  
        }  
    }  
}	
    }
}