using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace technicalTask
{
    public class ContainsClass
    {
        public Dictionary<int, int> ContainsMethod(string curFile, string curWord)
        {
            var wordsStat = new Dictionary<int, int>();

            if (!File.Exists(curFile))
            {
                Console.WriteLine();
                Console.WriteLine(string.Format("File '{0}' is absent in the specified directory", curFile));
                Console.ReadKey();
            }

            Console.WriteLine();
            Console.WriteLine("Your file exist in the specified directory");
            Console.WriteLine();
            
            try
            {
                using (var streamReader = new StreamReader(curFile))
                {
                    int numberOfString = 0;
                    string inputLine;
                    int amountInTheLine;
                    while (!streamReader.EndOfStream)
                    {
                        inputLine = streamReader.ReadLine();
                        numberOfString++;
                        amountInTheLine = 0;
                        if (inputLine.Contains(curWord))
                        {
                            amountInTheLine++;
                            wordsStat[numberOfString] = amountInTheLine;

                        }
                        

                    }
                    foreach (var numbers in wordsStat.OrderByDescending(ws => ws.Value))
                    {
                        Console.WriteLine("{0} --- {1}", numbers.Key, numbers.Value);
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("The programm failed with an error.");
                Console.WriteLine(ex.ToString());
            }
            return wordsStat;
        }

    }
}
