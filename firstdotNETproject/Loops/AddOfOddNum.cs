using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Loops
{
    class AddOfOddNum
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i=1; i<=20; i++)
            {
                if (!(i % 2 == 0))
                {
                    sum = sum + i;   
                }
            }
            Console.WriteLine($"Sum Of Odd Numbers Between 1 to 20 Is {sum}");
        }
    }
}
