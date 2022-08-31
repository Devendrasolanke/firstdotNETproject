using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.OopsConcepts
{
    class ConvToBinery
    {
        void Conv(int num)
        {
            int r;
            Console.WriteLine("Conert into Binery Number");
            for (int i=1; i<=num; i++)
            {
                r = num % 2;
                Console.Write("\t"+ r);
                num = num / 2;
            }
        }
        static void Main(string[] args)
        {
            ConvToBinery c1 = new ConvToBinery();
            Console.WriteLine("Enter the decimal number");
            int num = int.Parse(Console.ReadLine());
            c1.Conv(num);
        }
    }
}
