using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1
{
    public class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        readonly char[] vowels = { 'a', 'i', 'u', 'e', 'o' };

        List<int> values = new List<int>();
        public Analyse()
        {
            //Initialise all the values in the list to '0'
            for (int i = 0; i < 6; i++) { values.Add(0); }
        }
        public List<int> analyseText(string input)
        {
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters

            string[] sentanceList = input.Remove('*').Split('.', '!', '?');
            values[0] = sentanceList.Length;

            foreach (char character in input)
            {
                if (vowels.Contains(char.ToLower(character)))                       { values[1]++; }
                else if (char.IsLetter(character) && !(vowels.Contains(character))) { values[2]++; }

                if (char.IsUpper(character) && char.IsLetter(character))            { values[3]++; }
                else if (char.IsLower(character) && char.IsLetter(character))       { values[4]++; }
            }

            values[5] = values[4] + values[3];

            return values;
        }
    }
}
