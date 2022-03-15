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

            int characterCode = 0;

            foreach (char character in input)
            {
                characterCode = System.Convert.ToInt32(character);
                if (character == '.' || character == '?' || character == '!')
                {
                    values[0]++;
                }
                if (character == 'A' || character == 'E' || character == 'I' || character == 'U' || character == 'O' ||
                    character == 'a' || character == 'e' || character == 'i' || character == 'u' || character == 'o')
                {
                    values[1]++;
                }
                else if ((characterCode >= 65 && characterCode <= 90) || (characterCode >= 97 && characterCode <= 122))
                {
                    values[2]++;
                }
                if (characterCode >= 65 && characterCode <= 90)
                {
                    values[3]++;
                }
                else if (characterCode >= 97 && characterCode <= 122)
                {
                    values[4]++;
                }
            }
            
            foreach (char c in input)
            {
                if (c != ' ' && c != '.' && c != ','
                    && c != '!' && c != '?' && c != ':'
                    && c != ';' && c != '\'' && c != '\"'
                    && c != '*')
                {
                    values[5]++;
                }
            }
            return values;
        }
    }
}
