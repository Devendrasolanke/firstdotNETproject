using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Loops
{
    class SumOfNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                sum = sum + i;
             
            }
            Console.WriteLine($"Sum Of The Number Is Below\n{sum}");
                
        }
    }
}
