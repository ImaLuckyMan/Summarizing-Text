using System;

namespace Summerizing_Text 
{
    class Program   /* This will be used in order to summarize long text into shortend text followed by... */
    {
        static void Main(string[] args)
        {
            var sentance = "This is goint to be a really really really really really really long text"; //input string
            var summary = StringUtility.SummerizeText(sentance, 25); // calls method in StringUtility class with 25 character input
            Console.WriteLine(summary); // Displays results to the console
        }

        
    }
}
