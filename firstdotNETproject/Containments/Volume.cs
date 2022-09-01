using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Containments
{
    class Volume
    {
        double v;
        double volume(double r)
        {
            v = 4 / 3 * 22 / 7 * r * 3;
            return v;
        }
        double volume(double h, double r)
        {
            v = 22 / 7 * r * 2 * h;
            return v;
        }
        double volume(double l, double b, double h)
        {
            v = l * b * h;
            return v;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the redius");
            double red = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the hight");
            double hig = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter length");
            double len = double.Parse(Console.ReadLine());
            Console.WriteLine("Enetr the breadth");
            double bre = double.Parse(Console.ReadLine());
            Volume v1 = new Volume();
            double res1=v1.volume(red);
            double res2=v1.volume(hig, red);
            double res3=v1.volume(len, bre, hig);
            Console.WriteLine("Volume Of Sphare using only Redius : "+res1);
            Console.WriteLine("Volume Of Sphare using Hight and Redius : "+res2);
            Console.WriteLine("Volume Of Sphare using length, breadth and hight : "+res3);
        }
    } 
}
