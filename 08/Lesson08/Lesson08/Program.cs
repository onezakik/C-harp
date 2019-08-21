using System;
using System.IO;
using System.Text;

namespace Lesson08
{
	class Program
	{
		static void Main(string[] args)
		{
			const string fileName = @"test.txt";
			const string testMassage = "Hello world!";

			byte[] massageAnsiBytes = Encoding.ASCII.GetBytes(testMassage);

			FileStream testFileSteam = File.Open(
				fileName,
				FileMode.OpenOrCreate,
				//FileMode.Create,
				FileAccess.Write, 
				FileShare.Read);

			testFileSteam.Seek(0, SeekOrigin.End);
			testFileSteam.Write(massageAnsiBytes);
			testFileSteam.Flush();
			testFileSteam.Close();
			 

			//Console.ReadKey();
		}
	}
}
