using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1
{
    public class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)
        public void sentanceStatisticsOutput(string text, List<int> values, List<LQ> lqs)
        {
            string outputString = string.Empty;

            outputString =
                text +
                "\n\n\n*Testdata:\n" +
                $"Sentances:\t\t{values[0]}\n" +
                $"Total Characters:\t{values[5]}\n" +
                $"Vowels:\t\t\t{values[1]}\n" +
                $"Consonants:\t\t{values[2]}\n" +
                $"Upper Case:\t\t{values[3]}\n" +
                $"Lower Case:\t\t{values[4]}" +
                "\n\n*Doesn't include punctuation or whitespaces between words.\n";

            foreach (LQ lq in lqs)
            {
                outputString += $"{lq.quantity}: {lq.letter}\n";
            }

            Console.WriteLine("do you want to out put to: [text file/console]");
            string choice = string.Empty;
            while (true)
            {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                choice = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                if (choice == "console")
                {
                    Console.WriteLine(choice);
                    break;
                }
                else if (choice == "file")
                {
                    string path = string.Empty;
                    System.IO.File.WriteAllText(path, outputString);
                    break;
                }
            }
        }
    }
}