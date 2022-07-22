using System;

namespace Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            bool isPaswordContainsEnoughCharacters = ValidatePassword(text);
            bool isPaswordContainsOnlyDigitsandLetters = SymbolPasswordCheck(text);
            bool isEnoughDigit = DigitPasswordChecker(text);
            if (!isPaswordContainsEnoughCharacters)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isPaswordContainsOnlyDigitsandLetters)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!isEnoughDigit)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isPaswordContainsEnoughCharacters&&isEnoughDigit&&isPaswordContainsOnlyDigitsandLetters)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool DigitPasswordChecker(string text)
        {
            int countDigit = 0;
            foreach (char item in text)
            {
                if (char.IsDigit(item))
                {
                    countDigit++;
                    if (countDigit>=2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        static bool SymbolPasswordCheck(string text)
        {
            foreach (char letter in text)
            {
                if (!char.IsLetterOrDigit(letter))
                {
                    return false;
                }
            }
            return true;
        }

        static bool ValidatePassword(string text)
        {
            return text.Length >= 6 && text.Length <= 10;
        }
    }
}
