using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Assingment10Sept
{
    class CalAreaUsingSwitchCase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Redius of Circle");
            int red = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Side Value of Square");
            int side = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Length Of Rectangle");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Width Of Rectangle");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your Choice\nPress 1 for Area Of Circle\nPress 2 for Area Of Square\nPress 3 for Area Of Rectangle");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: Console.WriteLine($"Area Of Circle Is : {3.14*red*2}");
                    break;
                case 2: Console.WriteLine($"Enter The Square Is : {side*side}");
                    break;
                case 3: Console.WriteLine($"Area Of Rectangle Is : {length*width}");
                    break;
            }
        }
    }
}
