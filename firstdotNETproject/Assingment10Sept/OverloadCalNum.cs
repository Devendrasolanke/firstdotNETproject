using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Assingment10Sept
{
    class OverloadCalNum
    {
        static void Num_calc(int num, char ch)
        {
            int Res;
            if (ch == 's')
            {
                Res = (int)Math.Pow(num, 2);
                Console.WriteLine($"Square of {num} is : {Res}");
            }
            else
            {
                Res = (int)Math.Pow(num, 3);
                Console.WriteLine($"Cube of {num} is : {Res}");
            }
        }
        static void Num_calc(int a, int b, char ch)
        {
            int Res;
            if (ch == 'p')
            {
                Res = a * b;
                Console.WriteLine($"Product of {a} and {b} is : {Res}");
            }
            else
            {
                Res = a + b;
                Console.WriteLine($"Addition of {a} and {b} is : {Res}");
            }
        }
        static void Main(string[] args)
        {
            Num_calc(5, 's');
            Num_calc(5, 'a');
            Num_calc(5, 10, 'p');
            Num_calc(5, 10, 'a');
        }
        
    }
}
