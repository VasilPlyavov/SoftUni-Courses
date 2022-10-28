using System;

namespace Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            ValidatePassword(password);
        }
        static void ValidatePassword(string text)
        {
            bool invalid = false;
            if (text.Length < 6 || text.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                invalid = true;
            }
            if (ConsistsOnlyOfLettersAndDigits(text) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                invalid = true;
            }
            if (CountNumOfDigits(text) < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                invalid = true;
            }
            if (invalid == false)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool ConsistsOnlyOfLettersAndDigits(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                char currentNum = text[i];
                if (!((currentNum >= 48 && currentNum <= 57)
                   || (currentNum >= 65 && currentNum <= 90)
                   || (currentNum >= 97 && currentNum <= 122)))
                {
                    return false;
                }
            }
            return true;
        }
        static int CountNumOfDigits(string text)
        {
            int digitsCount = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= 48 && text[i] <= 57)
                {
                    digitsCount++;
                }
            }
            return digitsCount;
        }
    }
}
