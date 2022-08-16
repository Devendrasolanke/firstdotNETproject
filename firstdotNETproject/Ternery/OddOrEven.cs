using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Ternery
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            float num;
            Console.WriteLine("Enter The First Number");
            num = float.Parse(Console.ReadLine());
            string result = num % 2 == 0 ? "This Number Is even" : "This number Is Odd";
            Console.WriteLine(result);
        }
    }
}
