using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1
{
    public class Input
    {
        //Handles the text input for Assessment 1
        public string text = "nothing";

        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public void manualTextInput()
        {
            bool isCorrectInput = false;
            string tempText = "";
            while (isCorrectInput == false)
            {
                Console.Write("Enter Text input for analysis\n>");
                // Converting null literal or possible null value to non-nullable type.
                #pragma warning disable CS8600
                tempText = Console.ReadLine();
                #pragma warning restore CS8600
                if (tempText != "")
                {
                    Console.Write("do you want to enter this text? [y/n] ");
                    if (Console.ReadLine() != "n")
                    {
                        Console.WriteLine("press any key to continue");
                        Console.ReadLine(); Console.Clear();
                        text = tempText;
                        isCorrectInput = true;
                    }
                    else
                    {
                        Console.WriteLine("press any key to continue");
                        Console.ReadLine(); Console.Clear();
                    }
                }
                else
                {
                    Console.WriteLine("please renter text, press any key to continue");
                    Console.ReadLine(); Console.Clear();
                }
            }
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput(string fileName)
        {
            return text;
        }

    }
}
