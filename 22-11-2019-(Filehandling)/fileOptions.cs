using System;
using System.Threading.Tasks;
using System.IO;
using System.Text;
namespace FileHandling
{
    public class FileOptions
    {
        public static void Main(string[] args)
        {
		   Method();
        }
		static async void Method()
		{
			string str = "this is file option information";
			byte[] bytes = Encoding.Unicode.GetBytes(str);
			using(FileStream fs = File.Create("",4096, FileOptions.Asynchronous))
			{
				await fs.WriteAsync(bytes,0, bytes.Length);
			}
		}
    }
}