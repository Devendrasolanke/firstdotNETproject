using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Variables
{
    class Area_Of_Triangle
    {
        static void Main(String[] args)
        {
            int Base, Hight, Area;
            Console.WriteLine("Enter the Base Value");
            Base = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Hight Value");
            Hight = int.Parse(Console.ReadLine());
            Area = (Base * Hight) / 2;

            Console.WriteLine("Area Of Triangle Is "+Area);
        }
    }
}
