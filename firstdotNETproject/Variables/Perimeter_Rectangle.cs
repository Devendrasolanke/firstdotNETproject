using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Variables
{
    class Perimeter_Rectangle
    {
        static void Main(string[] args)
        {
            int Perimeter, Length, Width;
            Console.WriteLine("Enter The Rectangle Length");
            Length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Rectangle Width");
            Width = int.Parse(Console.ReadLine());
            Perimeter = Length + Width + Length + Width;
            Console.WriteLine($"The Perimeter Of The Rectangle Is {Perimeter}");
        }
    }
}
