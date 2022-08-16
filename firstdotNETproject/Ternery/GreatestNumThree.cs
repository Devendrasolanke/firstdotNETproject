using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Ternery
{
    class GreatestNumThree
    {
        static void Main(string[] args)
        {
            float result, num1, num2, num3;
            Console.WriteLine("Enter The First Number");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Second Number");
            num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Third Number");
            num3 = float.Parse(Console.ReadLine());
            result = (num1 > num2 && num1 > num3) ? num1 : (num2 > num1 && num2 > num3) ? num2 : num3;
            Console.WriteLine($"The Greatest Number In Between Three Number Is {result}");

        }
    }
}
