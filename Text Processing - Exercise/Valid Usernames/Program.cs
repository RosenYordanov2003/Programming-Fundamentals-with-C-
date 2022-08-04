using System;
using System.Linq;
using System.Text;

namespace Text_Processing___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string[]userNames=Console.ReadLine().Split(", ");
            StringBuilder validUserNames=new StringBuilder();
            int counter = 0;
            foreach (string word in userNames)
            {
                if (word.Length>=3&&word.Length<=16)
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        char currentLetter = word[i];
                        if (char.IsLetterOrDigit(currentLetter)||currentLetter=='-'||currentLetter=='_')
                        {
                            counter++;
                        }
                    }
                    if (counter==word.Length)
                    {
                        validUserNames.AppendLine(word);
                    }
                    counter = 0;
                }
            }
            Console.WriteLine(validUserNames.ToString());
        }
    }
}
