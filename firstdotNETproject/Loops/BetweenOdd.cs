using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Loops
{
    class BetweenOdd
    {
        static void Main(string[] args)
        {
            for(int i=15; i<=35; i++)
            {
                if (!(i%2==0))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
