using System;

namespace Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string comnad = string.Empty;
            bool isPalindrome = false;
            while ((comnad = Console.ReadLine()) != "END")
            {             
                bool result= CheckWhetherIsAPalindrome(comnad, isPalindrome);
              string resultAsText=result.ToString();
                Console.WriteLine(resultAsText.ToLower());
            }
        }

        static bool CheckWhetherIsAPalindrome(string comnad,bool isPalindrome)
        {
            string firstResult = string.Empty;
            for (int i = 0; i <comnad.Length; i++)
            {
                firstResult += comnad[i];
            }
            string reverseResult=string.Empty;
            for (int i = comnad.Length-1; i >=0 ; i--)
            {
                reverseResult += comnad[i];
            }
            if (firstResult==reverseResult)
            {
                isPalindrome = true;
            }
            else
            {
              isPalindrome=false;
            }
            return isPalindrome;
        }
    }
}
