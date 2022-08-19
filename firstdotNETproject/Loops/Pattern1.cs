using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Loops
{
    class Pattern1
    {
        public void Pattern01()
        {
            for (int i=1; i<=5; i++)
            {
                for (int j=1; j<=i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            
        }
        static void Main(string[] args)
        {
            Pattern1 p = new Pattern1();
            p.Pattern01();
        }
    }
}
