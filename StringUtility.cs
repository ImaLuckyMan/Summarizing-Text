using System;
using System.Collections.Generic;
using System.Text;

namespace Summerizing_Text
{
    public class StringUtility
    {
        public static string SummerizeText(string text, int maxLength = 20) // Method with 20 charactor default if one is not set
        {

            if (text.Length < maxLength) // If the text is less than length above then go ahead and print 
                return text;

            var words = text.Split(' '); // Break up the string by spaces into an array
            var totalCharacters = 0;
            var summaryWords = new List<string>(); // New place holder string array

            foreach (var word in words) // for each word broken up by spaces do the following
            {
                summaryWords.Add(word); // add the word

                totalCharacters += word.Length + 1; // count the characters of each word added plus 1 for the space
                if (totalCharacters > maxLength) // when the total reaches the maxLength set then break out of the loop
                    break;
            }

            return String.Join(" ", summaryWords) + "..."; ; //return the words that were added
        }
    }
}
    