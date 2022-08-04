using System;

namespace Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string text=Console.ReadLine();
            int counter = 0;
            int index = 0;
            for (int i = 0; i <text.Length-1; i++)
            {
                char firstChar = text[i];
                char secondChar = text[i+1];
                if (firstChar == secondChar)
                {
                    counter++;
                    if (counter==1)
                    {
                        index = i;
                    }
                    if (counter>0&&i>=text.Length-2)
                    {
                        string resultt = text.Substring(index, counter + 1);
                        text = text.Replace(resultt, firstChar.ToString());
                    }
                }
                else
                {
                    if (counter>=1)
                    {
                        string resultt = text.Substring(index, counter+1);
                        text = text.Replace(resultt, firstChar.ToString());
                        i = index;
                        index = 0;
                        counter = 0;
                    }
                }
            }
            Console.WriteLine(text);
        }
    }
}
