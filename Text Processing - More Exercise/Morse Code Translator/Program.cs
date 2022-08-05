using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Morse_Code_Translator
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Dictionary<string, string> morseCode = new Dictionary<string, string>();
            morseCode.Add(".-","A");
            morseCode.Add("-...", "B");
            morseCode.Add("-.-.", "C");
            morseCode.Add("-..", "D");
            morseCode.Add(".", "E");
            morseCode.Add("..-.", "F");
            morseCode.Add("--.", "G");
            morseCode.Add("....", "H");
            morseCode.Add("..", "I");
            morseCode.Add(".---", "J");
            morseCode.Add("-.-", "K");
            morseCode.Add(".-..", "L");
            morseCode.Add("--", "M");
            morseCode.Add("-.", "N");
            morseCode.Add("---", "O");
            morseCode.Add(".--.", "P");
            morseCode.Add("--.-", "Q");
            morseCode.Add(".-.", "R");
            morseCode.Add("...", "S");
            morseCode.Add("-", "T");
            morseCode.Add("..-", "U");
            morseCode.Add("...-", "V");
            morseCode.Add(".--", "W");
            morseCode.Add("-..-", "X");
            morseCode.Add("-.--", "Y");
            morseCode.Add("--..", "Z");
           StringBuilder result= new StringBuilder();
            string text = Console.ReadLine();
            string[] textAsArray = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in textAsArray)
            {
                string currentWord=word;
                if (morseCode.ContainsKey(word))
                {
                    result .Append(morseCode[word].ToString());
                }
                if (currentWord=="|")
                {
                    result.Append(" ");
                }
            }
            Console.WriteLine(result.ToString());
        }
    }
}
