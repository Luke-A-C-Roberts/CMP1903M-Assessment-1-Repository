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
        public List<int> AnalyseText(string input)
        {
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters

            foreach (char character in input)
            {
                //finds the number of sentences via punctuation
                if (character == '.' || character == '!' || character == '?')       { values[0]++; }

                //finds the number of vowels & consonants
                if (vowels.Contains(char.ToLower(character)))                       { values[1]++; }
                else if (char.IsLetter(character) && !(vowels.Contains(character))) { values[2]++; }

                //finds the number of upper and lower case characters
                if (char.IsUpper(character) && char.IsLetter(character))            { values[3]++; }
                else if (char.IsLower(character) && char.IsLetter(character))       { values[4]++; }
            }

            values[5] = values[4] + values[3];

            return values;
        }

        public List<LQ> AnalyseLetters(string input)
        {
            //creats set of all letters within the text
            HashSet<char> letterSet = new HashSet<char> ();
            foreach (char character in input)
            {
                if (char.IsLetter(character) == true)
                {
                    letterSet.Add(char.ToLower(character));
                }
            }

            //converts set to list and then sorts the list alphabetically
            List<char> letterList = new List<char> ();
            letterList = letterSet.ToList();
            letterList.Sort();

            //creats list used for counting the number of letters
            List<int> letterAmmountList = new List<int> ();

            //converts the text into an array of characters which is used for counting
            List<char> inputCharacters = new List<char>();
            inputCharacters = input.ToCharArray().ToList<char>();

            //goes through each letter in the list of characters and counts how many in the character list
            foreach (char character in letterList)
            {
                letterAmmountList.Add(inputCharacters.Count(s => s == character));
            }

            //list quantities struct list used to bind the quantities of letters to the character for sorting
            List<LQ> lqs = new List<LQ>();
            LQ tempLQ = new LQ();

            //both letter ammounts and letters from list added to letter quantity list
            for (int i = 0; i < letterList.Count; i++)
            {
                tempLQ.quantity = letterAmmountList[i];
                tempLQ.letter = letterList[i];
                lqs.Add(tempLQ);
            }

            //resets temp letter quantity struct
            tempLQ = new LQ();

            //bubble sort of letter quantities using letter quantity structs to keep the character and ammount parallel
            bool doSortLoop = true;
            while (doSortLoop == true)
            {
                doSortLoop = false;
                for (int i = 0; i < (lqs.Count - 1); i++)
                {
                    if (lqs[i].quantity < lqs[i + 1].quantity)
                    {
                        tempLQ = lqs[i];
                        lqs[i] = lqs[i + 1];
                        lqs[i + 1] = tempLQ;
                        doSortLoop = true;
                    }
                }
            }

            return lqs;
        }
    }
}
