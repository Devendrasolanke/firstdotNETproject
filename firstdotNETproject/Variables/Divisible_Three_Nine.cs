using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Variables
{
    class Divisible_Three_Nine
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number To Find Out Totally Divisible By Three and Nine");
            int num = int.Parse(Console.ReadLine());
            if (num%3==0 && num % 9 == 0)
            {
                Console.WriteLine("This Number Is Totally Divisible By Three and Nine"); 
            }
            else
            {
                Console.WriteLine("This Number Is Not Divisible By Three and Nine");
            }
        }
    }
}
