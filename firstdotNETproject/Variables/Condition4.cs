using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Variables
{
    class Condition4
    {
        //calculate the per for five subject marks
        static void Main(String[] args)
        {
            float per, total, English, Hindi, Marathi, Physics, Chemistry;
            Console.WriteLine("Enter the English marks");
            English = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Hindi marks");
            Hindi = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Marathi marks");
            Marathi = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Physics marks");
            Physics = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Chemistry marks");
            Chemistry = float.Parse(Console.ReadLine());
            total = English + Hindi + Marathi + Physics + Chemistry;
            Console.WriteLine("Total Obtained Marks");
            Console.WriteLine(total);
            per = ((total / 500) * 100);
            Console.WriteLine("Total Obtained Percentages");
            Console.WriteLine(per);

            if (per >= 70 && per <= 100)
            {
                Console.WriteLine("Pass with Distingution");
            }
            else if (per>=60 && per <= 70)
            {
                Console.WriteLine("Pass with 1st class");
            }
            else if (per >=50 && per <= 60)
            {
                Console.WriteLine("Pass with 2nd class");
            }
            else if (per >=35 && per <= 50)
            {
                Console.WriteLine("Pass class");
            }
            else
            {
                Console.WriteLine("Sorry your result is fail");
            }
        }
    }
}
