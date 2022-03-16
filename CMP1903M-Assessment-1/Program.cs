﻿//Base code project for CMP1903M Assessment 1
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
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();
            
            //Create 'Input' object
            //Get either manually entered text, or text from a file
            Input inputObject = new Input();

            bool isAllowedInputChoice = false;
            string inputChoice = "";
            while (isAllowedInputChoice == false)
            {
                Console.Write("1. Do you want to enter the text via the keyboard?\n" +
                    "2. Do you want to read in the text from a file?\n> ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                inputChoice = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                if (inputChoice == "1" || inputChoice == "2")
                {
                    isAllowedInputChoice = true;
                    Console.WriteLine("Press any key to continue");
                    Console.ReadLine(); Console.Clear();
                }
                else
                {
                    Console.WriteLine("Please re-enter choice");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadLine(); Console.Clear();
                }
            }
            if (inputChoice == "1")
            {
                inputObject.manualTextInput();
            }
            else if (inputChoice == "2")
            {
                inputObject.fileTextInput();
            }

            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method
            //Receive a list of integers back
            Analyse analysis = new Analyse();
            parameters = analysis.analyseText(inputObject.text);

            //Report the results of the analysis
            Report report = new Report();
            report.outputConsole(inputObject.text, parameters);

            //TO ADD: Get the frequency of individual letters?
        }
    }
}
