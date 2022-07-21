using System;

namespace Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type=="int")
            {
                int number1=int.Parse(Console.ReadLine());
                int number2=int.Parse(Console.ReadLine());
                int result= GetMax(number1,number2);
                Console.WriteLine(result);
            }
            else if (type == "char")
            {
                char firstChar=char.Parse(Console.ReadLine());
                char secondChar=char.Parse(Console.ReadLine());
               char result= GetMax(firstChar,secondChar);
                Console.WriteLine(result);
            }
            else if (type=="string")
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();
                string result= GetMax(firstString,secondString);
                Console.WriteLine(result);
            }
        }

        static int GetMax(int number1,int number2)
        {
            if (number1>number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }
        static char GetMax(char firstChar, char secondChar)
        {
            if (secondChar> firstChar)
            {
                return secondChar;
            }
            else
            {
                return firstChar;
            }
        }
        static string GetMax(string firsString,string SecondString)
        {
            int result=firsString.CompareTo(SecondString);
            if (result < 0)
            {
                return SecondString;
            }
            else if (result>1)
            {
                return firsString;
            }
            else
            {
                return firsString;
            }
        }
    }
}
