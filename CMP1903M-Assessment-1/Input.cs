﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1
{
    public class Input
    {
        //Handles the text input for Assessment 1
        private string _text = "";
        private int _sentenceNumber = 0;
        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard

        public string text
        {
            get { return _text; }
            set { _text = value; }
        }

        public int sentenceNumber
        {
            get { return _sentenceNumber; }
            set { _sentenceNumber = value; }
        }

        public string manualTextInput()
        {
            string tempText = "";
            string tempSentence = "";
            bool contiueLoop = true;

            // loops through
            Console.WriteLine("Please enter text\n if you have finished entering sentences end with \"*\" character");
            while (contiueLoop == true)
            {
                Console.Write("> ");

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                tempSentence = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

                Console.Write("");
                if (!(tempSentence == "" && tempSentence == null))
                {
                    // ends the loop if the sentence is *
                    if (tempSentence == "*")
                    {
                        tempText += tempSentence;
                        contiueLoop = false;
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine(); Console.Clear();
                    }
                    else
                    {

                        // makes sure that the sentances are punctuated correctly
                        if (tempText.EndsWith(". ") || tempText.EndsWith("! ") || tempText.EndsWith("? "))
                        {
                            tempText += tempSentence;
                        }
                        else if (tempText.EndsWith(".") || tempText.EndsWith("!") || tempText.EndsWith("?"))
                        {
                            tempText += (" " + tempSentence);
                        }
                        else if (tempText.Length > 0)
                        {
                            tempText += (". " + tempSentence);
                        }
                        else
                        {
                            tempText += tempSentence;
                        }

                    }

                    // checks if the sentence ends in * (if so it breaks while loop)
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    if (tempSentence.EndsWith("*"))
                    {
                        contiueLoop = false;
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine(); Console.Clear();
                    }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                }
            }

            //if the text doesnt end in .*, !* or ?* then .* is automatically added to the end
            if (!(tempText.EndsWith(".*") || tempText.EndsWith("!*") || tempText.EndsWith("?*")))
            {
                tempText = tempText.Remove(tempText.Length - 1) + ".*"; 
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
            string fileName = "";

            while (true)
            {
                Console.Write("Enter full path of the .txt file\n> ");
                // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8600
                fileName = Console.ReadLine();
#pragma warning restore CS8600
                // Dereference of a possibly null reference.
#pragma warning disable CS8602
                //checks if the file exists
                if (System.IO.File.Exists(fileName) == true
                    && fileName.EndsWith(".txt") == true)
                {
                    //asks for users consent
                    Console.Write("Are you sure you want to use this file [y/n]? ");
                    if (Console.ReadLine() != "n")
                    {
                        text = System.IO.File.ReadAllText(fileName) + "*";
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine(); Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine(); Console.Clear();
                    }
                }
                else
                {
                    if (System.IO.File.Exists(fileName) == false) { Console.WriteLine("file could not be found"); }
                    if (fileName.EndsWith(".txt") == false) { Console.WriteLine("the file provided was not a .txt file"); }
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine(); Console.Clear();
                }
#pragma warning restore CS8602
            }
        }
    }
}
