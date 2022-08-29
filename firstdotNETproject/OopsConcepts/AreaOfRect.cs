using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.OopsConcepts
{
    class AreaOfRect
    {
        static int length, width, area, perimeter;
        void Input()
        {
            Console.WriteLine("Enetr\nlength\nwidth");
            length = int.Parse(Console.ReadLine());
            width = int.Parse(Console.ReadLine());

        }
        void Calculate()
        {
            area = length * width;
            perimeter = 2 * (length * width);
        }
        void Display()
        {
            Console.WriteLine("Area of Rectangle is " + area);
            Console.WriteLine("Perimeter of Rectangle is " + perimeter);
        }
        static void Main(string[] args)
        {
            AreaOfRect a = new AreaOfRect();
            a.Input();
            a.Calculate();
            a.Display();
        }
    }
}
