using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Loops
{
    class PowerNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The BaseNumber");
            int basenum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Exponential");
            int expo = int.Parse(Console.ReadLine());
            int power = 1;
            for (int i=1; i<=expo; i++)
            {
                power = power * basenum;
            }
            Console.WriteLine($"The Power Of This Number Is {power}");
        }
    }
}
