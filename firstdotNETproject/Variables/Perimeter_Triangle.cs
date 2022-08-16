using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Variables
{
    class Perimeter_Triangle
    {
        static void Main(string[] args)
        {
            int Perimeter, a, b, c;
            Console.WriteLine("Enter the First Side Length Of Triangle");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Seconde Side Length of Triangle");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Third Side Length Of Triangle");
            c = int.Parse(Console.ReadLine());
            Perimeter = a + b + c;
            Console.WriteLine($" {Perimeter} This Is The Perimeter Of Triangle");
        }
    }
}
