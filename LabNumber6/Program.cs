using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
// still needs to prompt user to continue, convert all to lower case, move all the consonants before the first vowel, don't translate words with special characters or numbers
namespace LabNumber6
{
    class Program
    {

        static void Main(string[] args)
        {

            char[] consonants = "BCDFGHJKLMNPQRSTVWXYZbcdfghjklmnpqrstvwxyz".ToCharArray();
            char[] vowels = "AEIOUaeiou".ToCharArray();
            StringBuilder pigLatin = new StringBuilder();
            Console.WriteLine("Welcome to the Pig Latin Translator!");
            Console.WriteLine();
            Console.Write("Enter a line to be translated: ");

            string[] sentenceArray = GetInput().Split(' ');
            TranslateWords(sentenceArray, vowels);
        }

        private static void TranslateWords(string[] sentenceArray, char[] vowels)
        {
            foreach (string word in sentenceArray)
            {
                if (vowels.Contains(word[0]))
                {
                    Console.Write(word + "way ");
                }
                else
                {
                    Console.Write(word.Remove(0, 1) + word[0] + "ay ");
                }
            }
        }

        static string GetInput()
        {
            string input = Console.ReadLine();
            input.Trim();      
            return input;
        }
    }
}
