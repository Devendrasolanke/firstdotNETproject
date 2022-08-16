using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Variables
{
    class Condition2
    {
        //if else ladder condition program / num is positive, nigative or zero
        static void Main(String[] args)
        {
            Console.WriteLine(" Write a number ");
            int num = int.Parse(Console.ReadLine());

            if (num > 0 )
            {
                Console.WriteLine("Num is positive");
            }
            else if (num == 0 )
            {
                Console.WriteLine(" Num is zero");
            }
            else
            {
                Console.WriteLine(" Num is nigative");
            }

        }
    }
}
