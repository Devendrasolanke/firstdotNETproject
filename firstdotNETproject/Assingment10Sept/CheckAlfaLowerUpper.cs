using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Assingment10Sept
{
    class CheckAlfaLowerUpper
    {
        static void Check(char ch)
        {
            if (ch>='a' && ch <= 'z')
            {
                Console.WriteLine("This Is Lower Case Charecter");
            }
            else if (ch>='A' && ch <= 'Z')
            {
                Console.WriteLine("This Is Upper Case Charecter");
            }
            else
            {
                Console.WriteLine("Invalid Entry, Please Enter Valid Charecter");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Charecter");
            char ch = Convert.ToChar(Console.ReadLine());
            Check(ch);

        }
    }
}
