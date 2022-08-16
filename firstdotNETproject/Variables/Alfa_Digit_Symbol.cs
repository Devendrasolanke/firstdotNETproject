using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Variables
{
    class Alfa_Digit_Symbol
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Charecter");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch >= 'a' && ch <= 'z')
            {
                Console.WriteLine("This Is Alfabate");
            }
            else if (ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine("This Is Alfabate");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine("This Is Digit");
            }
            else
            {
                Console.WriteLine("This Is Symbole");
            }
        }
    }
}
