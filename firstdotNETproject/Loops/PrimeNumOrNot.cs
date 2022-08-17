using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Loops
{
    class PrimeNumOrNot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int num = int.Parse(Console.ReadLine());
            bool flag = true;

            for (int i=2; i<num; i++)
            {
                if (num % i == 0)
                {
                    flag = false;
                }
            }
            if (flag ==true)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
           
        }
    }
}
