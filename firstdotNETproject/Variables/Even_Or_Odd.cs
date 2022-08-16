using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Variables
{
    class Even_Or_Odd
    {
        static void Main(String[] args)
        {
            int num;
            Console.WriteLine("Enter the Number");
            num = int.Parse(Console.ReadLine());

            if (num%2==0)
            {
                Console.WriteLine("The Given Number Is Even");
            }
            else
            {
                Console.WriteLine("The Given Number Is Odd");
            }
        }
    }
}
