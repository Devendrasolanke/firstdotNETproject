using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.SwitchCases
{
    class Vowel_Consonant
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Charecter");
            char ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U': Console.WriteLine("This Charecter Is Vowel");
                    break;
                default: Console.WriteLine("This Charecter Is Consonant Or Digit Or Symbol");
                    break;

            }
        }
    }
}
