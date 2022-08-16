using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Variables
{
    class Area_Of_Square
    {
        static void Main(String[] args)
        {
            int square, area;
            Console.WriteLine("Enter the value of square");
            square = int.Parse(Console.ReadLine());
            area = square * square;

            Console.WriteLine("Area of Square is " + area);
        }
    }
}
