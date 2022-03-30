using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1
{
    public class Report
    {
        public void sentanceStatisticsOutput(string text, List<int> values, List<LQ> lqs)
        {

            // creates output string
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

            // goes through each letter in the letter quantitiy list and adds to output string
            foreach (LQ lq in lqs)
            {
                outputString += $"{lq.quantity}: {lq.letter}\n";
            }

            // choice between file and console output
            Console.WriteLine("do you want to out put to: [file/console]");
            string choice = string.Empty;
            // loops untill choice is either console or file
            while (true)
            {
                Console.Write("> ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                choice = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                if (choice == "console" || choice == "file")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please re-enter choice");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine(); Console.Clear();
                }
            }
            //outputs to either the console or to a file with specified path
            if (choice == "console")
            {
                Console.WriteLine(outputString);
            }
            else if (choice == "file")
            {
                string path = string.Empty;
                while (true)
                {
                    Console.WriteLine("where would you like to output to?");
                    Console.Write("> ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    path = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                    Console.Write("Are you sure you want to use this file [y/n]? ");

                    // asks for users consent
                    if (Console.ReadLine() != "n")
                    {
                        try
                        {
                            System.IO.File.WriteAllText(path, outputString);
                            break;
                        }
                        catch (System.IO.IOException e)
                        {
                            Console.WriteLine($"exception {e}");
                            Console.WriteLine("Press Enter to continue");
                            Console.ReadLine(); Console.Clear();
                        }
                    }
                    else
                    {
                        {
                            Console.WriteLine("Press Enter to continue");
                            Console.ReadLine(); Console.Clear();
                        }
                    }
                }
            }
        }
    }
}