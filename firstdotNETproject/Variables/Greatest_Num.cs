using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Variables
{
    class Greatest_Num
    {
        static void Main(string[] args)
        {
            float num1, num2, num3;
            Console.WriteLine("Enter The First Number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Second Number");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Third Number");
            num3 = int.Parse(Console.ReadLine());
            if (num1>num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine($"{num1} Is Greatest Number");
                }
                else
                {
                    Console.WriteLine($"{num3} Is Greatest Number");
                }
             
            }
            else if (num2 > num3)
            {
                if (num2 > num3)
                {
                    Console.WriteLine($"{num2} Is Greatest Number");
                }
                else
                {
                    Console.WriteLine($"{num3} Is Greatest Number");
                }
            }
        }
    }
}
