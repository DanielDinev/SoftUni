using System;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {


            string password = Console.ReadLine();
            if (CharCount(password) && LetterAndDigits(password) && HaveTwoDigits(password))
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (CharCount(password) == false)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (LetterAndDigits(password) == false)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (HaveTwoDigits(password) == false)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }






            

        }
        static bool CharCount(string text)
        {
            int count = text.Length;
            if (count >= 6 && count <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool LetterAndDigits(string text)
        {
            bool curr;
            for (int i = 0; i < text.Length; i++)
            {
                if ((text[i] >= 48 && text[i] <= 57) || (text [i] >= 65 && text[i] <=90) || (text[i] >= 97 && text[i] <= 122))
                {
                    curr = true;
                }
                else
                {
                    return false;
                }
               
                   
               
            }
            return true;

        } 
        static bool HaveTwoDigits (string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= 48 && text[i] <= 57)
                {
                    count++;
                }
            }
            if (count >=2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    
}
