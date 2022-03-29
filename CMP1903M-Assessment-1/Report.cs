﻿using System;
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
        public void sentanceStatisticsOutput(string text, List<int> values)
        {
            
            Console.WriteLine
                (
                text + "\n\n\n*Testdata:\n" +
                $"Sentances:\t\t{values[0]}\n" +
                $"Total Characters:\t{values[5]}\n" +
                $"Vowels:\t\t\t{values[1]}\n" +
                $"Consonants:\t\t{values[2]}\n" +
                $"Upper Case:\t\t{values[3]}\n" +
                $"Lower Case:\t\t{values[4]}" +
                "\n\n*Doesn't include punctuation or whitespaces between words."
                );
        }
        public void characterStatisticsOutput(LQ lqs)
        {

        }
    }
}
