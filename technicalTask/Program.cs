using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace technicalTask
{
	class Program
	{
		static void Main(string[] args)
		{
			var separators = new char[]{ ' ', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '!', '@', '#', '%', '\'', '/',
						'$', '&', '*', ';', ':', '.', ',', '-', '_', '^', '(', ')', '[', ']', '{', '}', '/', '?', '\n', '\t', '\r' };
			var wordsStat = new Dictionary<string, int>();

			Console.WriteLine("Enter file path:");
            //string curFile = Console.ReadLine();
            string curFile = "D:\\TestFile.txt";
            Console.WriteLine("Enter word:");
            string curWord = Console.ReadLine();
            int curAmount = 0;
			if (!File.Exists(curFile))
			{
				Console.WriteLine();
				Console.WriteLine(string.Format("File '{0}' is absent in the specified directory", curFile));
				Console.ReadKey();
				return;
			}

			Console.WriteLine();
			Console.WriteLine("Your file exist in the specified directory\n");
			try
			{
				using (var streamReader = new StreamReader(curFile))
				{
					string inputLine;
					// To optimize the use of memory, we are reading file line by line
					while (!streamReader.EndOfStream)
					{
						inputLine = streamReader.ReadLine();
						var words = inputLine.Split(separators, StringSplitOptions.RemoveEmptyEntries);

						foreach (string word in words)
						{
							if (wordsStat.ContainsKey(word))
							{
								wordsStat[word]++;
							}
							else
							{
								wordsStat[word] = 1;
							}
						}
					}
				}
				
				foreach (var wordsNumber in wordsStat.OrderByDescending(ws => ws.Value))
				{
                    if (curWord == wordsNumber.Key)
                    {
                        curWord = wordsNumber.Key;
                        curAmount = wordsNumber.Value;
                    }
				}
                Console.WriteLine("The word that you are looking for is " +
                            "called {0} and it is found {1} times", curWord, curAmount);
            }
			catch (Exception ex)
			{
				Console.WriteLine("The programm failed with an error.");
				Console.WriteLine(ex.ToString());
			}

			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();
		}
	}
}
