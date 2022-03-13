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
            while (isCorrectInput == false)
            {
                Console.Write("Enter Text input for analysis\n>");
                text = Console.ReadLine();
                if (text != null || text == "")
                {
                    isCorrectInput = true;
                    Console.Write("do you want to enter this text? [y/n] ");
                    if (Console.ReadLine() != "n")
                    {
                        Console.WriteLine("press any key to continue");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("press any key to continue");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                else
                {
                    Console.WriteLine("please renter text, press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
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
