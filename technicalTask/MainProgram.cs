using System.Configuration;
using System.Collections.Specialized;
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
            //input values using app.config for curFile and curWord
            string curFile = ConfigurationManager.AppSettings.Get("sValueCurFile");
            string curWord = ConfigurationManager.AppSettings.Get("sValueCurWord");

            var findTheWord = new FindTheWord();
            Console.WriteLine("Enter file path:");
            //string curFile = Console.ReadLine();
            //string curFile = "D:\\CallController.log";

            Console.WriteLine("Enter word:");
            //string curWord = Console.ReadLine();
            //string curWord = "StarWars";
            /*
            foreach (var wordsNumber in findTheWord.FindTheWordInTheText(curFile, curWord).OrderByDescending(ws => ws.Value))
            {
                Console.WriteLine("Substring {0} is in line #{1} and occurs <<< {2} >>> ", curWord, wordsNumber.Key, wordsNumber.Value);
            }
            Console.WriteLine("Press any key to exit.");*/

            string result = findTheWord.FindTheWordInTheText(curFile, curWord).Values.Last().ToString();
            Console.WriteLine(result);

            Console.ReadKey();
        }
	}
}
