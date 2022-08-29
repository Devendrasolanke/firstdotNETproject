using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.OopsConcepts
{
    class CalFrq
    {
        void Number(int num, int d)
        {
            int counter, r;
            counter = 0;
            while (num > 0)
            {
                r = num % 10;
                if (r == d)
                {
                    counter++;
                }
                num = num / 10;
            }
            Console.WriteLine("Frq of digit is " + counter);
        }

        void Number(int n1)
        {
            int sum = 0, r;
            while (n1 > 0)
            {
                r = n1 % 10;
                if (r % 2 == 0)
                {
                    sum = sum + r;
                }
                n1 = n1 / 10;
            }
            Console.WriteLine("Sum of even number " + sum);
        }

        static void Main(string[] args)
        {
            CalFrq c = new CalFrq();
            Console.WriteLine("Enter the Number ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the digit for calculating frq");
            int frq = int.Parse(Console.ReadLine());
            c.Number(num, frq);
            Console.WriteLine("Enter the number for calculating even digits");
            int num2 = int.Parse(Console.ReadLine());
            c.Number(num2);
        }
    }
}
