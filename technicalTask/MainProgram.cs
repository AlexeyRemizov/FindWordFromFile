using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace technicalTask
{
	public class MainProgram
	{
		public static void Main(string[] args)
		{
            var findTheWord = new FindTheWord();
            findTheWord.FindTheWordInTheText();
			Console.WriteLine("Press any key to exit.");

            Console.ReadKey();
		}
	}
}
