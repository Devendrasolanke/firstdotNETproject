using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.SwitchCases
{
    class Pos_Neg_Zero
    {
        static void Main(string[] args)
        {
            float num, final;
            Console.WriteLine("Enter The Number");
            num = float.Parse(Console.ReadLine());
            if (num > 0)
            {
                final = num;
                final = 1;
            }
            else if (num == 0)
            {
                final = num;
                final = 2;
            }
            else
            {
                final = num;
                final = 3;
            }
            switch (final)
            {
                case 1: Console.WriteLine("This Number Is Positive");
                    break;
                case 2: Console.WriteLine("This Number Is Zero");
                    break;
                case 3: Console.WriteLine("This Number Is Negative");
                    break;
            }
        }
    }
}
