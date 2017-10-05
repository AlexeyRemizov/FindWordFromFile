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
            Console.WriteLine("Enter file path:");
            //string curFile = Console.ReadLine();
            string curFile = "D:\\InformLauncherLog3.txt";

            Console.WriteLine("Enter word:");
            //string curWord = Console.ReadLine();
            string curWord = "2017-06";
            findTheWord.FindTheWordInTheText(curFile, curWord);
			Console.WriteLine("Press any key to exit.");

            Console.ReadKey();
		}
	}
}
