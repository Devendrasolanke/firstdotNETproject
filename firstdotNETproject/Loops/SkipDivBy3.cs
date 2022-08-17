using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Loops
{
    class SkipDivBy3
    {
        static void Main(string[] args)
        {
            for (int i=1; i<=20; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);

            }

        }
    }
}
