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

            //object creation
            Input inputObject = new Input();
            Analyse analyseObject = new Analyse();
            Report reportObject = new Report();

            string inputChoice = "";
            while (true)
            {
                Console.Write("1. Do you want to enter the text via the keyboard?\n" +
                    "2. Do you want to read in the text from a file?\n" +
                    "3. do you want to compare to test file\n>");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                inputChoice = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                if (inputChoice == "1" || inputChoice == "2" || inputChoice == "3")
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

                //creates analysis object and undergoes subroutines
                parameters = analyseObject.AnalyseText(inputObject.text);
                lqs = analyseObject.AnalyseLetters(inputObject.text);
                longWords = analyseObject.LongWords(inputObject.text);

                //report
                reportObject.sentanceStatisticsOutput(inputObject.text, parameters, lqs, longWords);
            }
            else if (inputChoice == "2")
            {
                //file input method
                inputObject.fileTextInput();

                //creates analysis object and undergoes subroutines
                parameters = analyseObject.AnalyseText(inputObject.text);
                lqs = analyseObject.AnalyseLetters(inputObject.text);
                longWords = analyseObject.LongWords(inputObject.text);

                //report
                reportObject.sentanceStatisticsOutput(inputObject.text, parameters, lqs, longWords);
            }
            else if (inputChoice == "3")
            {
                inputObject.CompareAgainstTestFileInput();

                parameters = analyseObject.AnalyseText(inputObject.text);

                reportObject.CompareAgainstTestFileOutput(inputObject.text, parameters);



            }

        }
    }
}
