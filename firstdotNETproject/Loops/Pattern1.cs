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
    class Pattern2
    {
        public void Pattern02()
        {
            for (int i=5; i>=1; i--)
            {
                for (int j=5; j>=i; j--)
                {
                    Console.Write($" {j}");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Pattern2 a = new Pattern2();
            a.Pattern02();
        }
    }

    class Pattern3
    {
        public void Pattern03()
        {
            for (int i=1; i<5; i++)
            {
                for (int j=i; j<5; j++)
                {
                    Console.Write(" ");
                }
                
                for (int z = 1; z < (i * 2); z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Pattern3 b = new Pattern3();
            b.Pattern03();
        }
    }
}
