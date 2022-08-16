using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Ternery
{
    class MaxNumTwo
    {
        static void Main(string[] args)
        {
            float num1, num2, result;
            Console.WriteLine("Enter The First Number");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Second Number");
            num2 = float.Parse(Console.ReadLine());
            result = num1 > num2 ? num1 : num2;
            Console.WriteLine($"The Greatest Number Is {result}");
        }
    }
}
