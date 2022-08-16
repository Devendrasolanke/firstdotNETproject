using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.SwitchCases
{
    class Odd_Even
    {
        static void Main(string[] args)
        {
            int num, number;
            Console.WriteLine("Enter The Number");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                number= num;
                number = 1;
            }
            else
            {
                number = num;
                number = 2;
            }
            switch (number)
            {
                case 1: Console.WriteLine("This Number is Even");
                    break;
                case 2: Console.WriteLine("This Number is Odd");
                    break;
            }
        }
    }
}
