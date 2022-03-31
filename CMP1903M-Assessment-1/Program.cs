//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1
{
    class Program
    {
        static void Main()
        {
            //lists of data used for report
            List<int> parameters = new List<int>();
            List<LQ> lqs = new List<LQ>();
            List<string> longWords = new List<string>();

            Input inputObject = new Input();

            string inputChoice = "";
            while (true)
            {
                Console.Write("1. Do you want to enter the text via the keyboard?\n" +
                    "2. Do you want to read in the text from a file?\n> ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                inputChoice = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                if (inputChoice == "1" || inputChoice == "2")
                {
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine(); Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("Please re-enter choice");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine(); Console.Clear();
                }
            }
            if (inputChoice == "1")
            {
                //manual input method
                inputObject.manualTextInput();
            }
            else if (inputChoice == "2")
            {
                //file input method
                inputObject.fileTextInput();
            }

            //creates analysis object and undergoes subroutines
            Analyse analysis = new Analyse();
            parameters = analysis.AnalyseText(inputObject.text);
            lqs = analysis.AnalyseLetters(inputObject.text);
            longWords = analysis.LongWords(inputObject.text);
            
            //report
            Report report = new Report();
            report.sentanceStatisticsOutput(inputObject.text, parameters, lqs, longWords);
        }
    }
}
