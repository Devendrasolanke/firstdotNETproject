using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Variables
{
    class Area_Of_Cube
    {
        static void Main(String[] args)
        {
            int Edge, Area;
            Console.WriteLine("Enter the value of edge");
            Edge = int.Parse(Console.ReadLine());
            Area = 6 * (Edge * Edge);

            Console.WriteLine("Area of Cube " + Area);
        }
    }
}
