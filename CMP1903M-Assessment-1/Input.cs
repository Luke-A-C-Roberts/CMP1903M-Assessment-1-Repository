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
        internal string text = "";
        internal int sentenceNumber = 0;
        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string manualTextInput()
        {
            string tempText = "";
            string tempSentence = "";
            bool contiueLoop = true;
            Console.WriteLine("Please enter text\n" +
                "if you have finished entering sentences end with \"*\" character");
            while (contiueLoop == true)
            {
                Console.Write(">");
                tempSentence = Console.ReadLine();
                Console.Write("\n");
                if (tempSentence != "" && tempSentence != "*")
                {
                    if (tempSentence.EndsWith(". ")
                        || tempSentence.EndsWith(".*")
                        || tempSentence.EndsWith("! ")
                        || tempSentence.EndsWith("!*")
                        || tempSentence.EndsWith("? ")
                        || tempSentence.EndsWith("?*"))
                    {
                        tempText += tempSentence;
                    }
                    else if (tempSentence.EndsWith(".")
                        || tempSentence.EndsWith("!")
                        || tempSentence.EndsWith("?"))
                    {
                        tempText += (tempSentence + " ");
                    }
                    else
                    {
                        tempText += (tempSentence + ". ");
                    }

                    if (tempSentence.EndsWith("*"))
                    {
                        contiueLoop = false;
                        Console.WriteLine("Press any key to continue");
                        Console.ReadLine(); Console.Clear();
                    }
                }
            }
            text = tempText;
            return tempText;
        }
        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public void fileTextInput()
        {
            bool hasFoundFile = false;
            string fileName = "";

            while (hasFoundFile == false)
            {
                Console.Write("Enter full path of the .txt file\n> ");
                // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8600
                fileName = Console.ReadLine();
#pragma warning restore CS8600
                // Dereference of a possibly null reference.
#pragma warning disable CS8602
                if (System.IO.File.Exists(fileName) == true
                    && fileName.EndsWith(".txt") == true)
                {
                    Console.WriteLine("Are you sure you want to use this file [y/n]? ");
                    if (Console.ReadLine() != "n")
                    {
                        hasFoundFile = true;
                        text = System.IO.File.ReadAllText(fileName);
                        Console.WriteLine("Press any key to continue");
                        Console.ReadLine(); Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Press any key to continue");
                        Console.ReadLine(); Console.Clear();
                    }
                }
                else
                {
                    if (System.IO.File.Exists(fileName) == false) { Console.WriteLine("file could not be found"); }
                    if (fileName.EndsWith(".txt") == true) { Console.WriteLine("the file provided was not a .txt file"); }
                    Console.WriteLine("Press any key to continue");
                    Console.ReadLine(); Console.Clear();
                }
#pragma warning restore CS8602
            }
        }
    }
}
