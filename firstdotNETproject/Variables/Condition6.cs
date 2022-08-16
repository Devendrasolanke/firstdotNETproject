using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Variables
{
    class Condition6
    {
        //Area of Triangle for Three sides
        static void Main(String[] args)
        {
            float a, b, c, s, area;
            Console.WriteLine("Enter the A side value");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the B side value");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the C side value");
            c = float.Parse(Console.ReadLine());
            s = (a + b + c) / 2;
            //  onsole.WriteLine(s);
            area = (s * (s - a) * (s - b) * (s - c));
            Console.WriteLine("Area of Triangle "+area);

        }
    }
}
