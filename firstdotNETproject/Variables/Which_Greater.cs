using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Variables
{
    class Which_Greater
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the First Number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"The Number1 {num1} Is Greater than Number2 {num2}.....!");
            }
            else
            {
                Console.WriteLine($"The Number2 {num2} Is Greater than Number1 {num1}.....!");
            }
        }
    }
}
