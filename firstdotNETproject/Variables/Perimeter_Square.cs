using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Variables
{
    class Perimeter_Square
    {
        static void Main(string[] args)
        {
            int Perimeter, Length;
            Console.WriteLine("Enter The Length Of Square");
            Length = int.Parse(Console.ReadLine());
            Perimeter = Length + Length + Length + Length;
            Console.WriteLine($" {Perimeter} This Is Perimeter Of Square");

        }
    }
}
