using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace technicalTask
{
    public class FindTheWord
    {
        
        public Dictionary<int, int> FindTheWordInTheText(string curFile, string curWord)
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
            int amountInTheLine;
            try
            {
                using (var streamReader = new StreamReader(curFile))
                {
                    int numberOfString = 0;
                    string inputLine;

                    while (!streamReader.EndOfStream)
                    {
                        inputLine = streamReader.ReadLine();
                        numberOfString++;
                        amountInTheLine = new Regex(curWord).Matches(inputLine).Count;
                        if (amountInTheLine > 0)
                        {
                            wordsStat[numberOfString] = amountInTheLine;
                        }
                        
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
