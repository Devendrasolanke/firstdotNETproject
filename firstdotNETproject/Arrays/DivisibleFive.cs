using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Arrays
{
    class DivisibleFive
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter The Number");
            num = int.Parse(Console.ReadLine());
            if (num % 5 == 0)
            {
                Console.WriteLine("The Number Is Totally Divisible By 5");
            }
            else
            {
                Console.WriteLine("The Number Is Not Divisible By 5");
            }
        }
    }
}
