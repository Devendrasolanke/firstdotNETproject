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
                    Console.Write(" ");
                }
                Console.WriteLine(i);
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
                    Console.Write(z);
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

    class Pattern4
    {
        static void Main(string[] args)
        {
            for (int r=5; r>=1; r--)
            {
                for (int c=5; c>=r; c--)
                {
                    Console.Write(r);
                }
                Console.WriteLine();
            }
        }
    }

    class Pattern5
    {
        static void Main(string[] args)
        {
            for(char ch='E'; ch>='A'; ch--)
            {
                for(char bh='A'; bh<=ch; bh++)
                {
                    Console.Write(bh);
                }
                Console.WriteLine();
            }
                
        }
    }

    class Pattern6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Line You Wants");
            int num = int.Parse(Console.ReadLine());
            int line = num;
            for (int r=1; r<=line; r++)
            {
                for (int space=r; space<line; space++)
                {
                    Console.Write(" ");
                }
                for(int c=1; c<=r; c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }
    }

    class Pattern7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Line You Wants");
            int num = int.Parse(Console.ReadLine());
            int line = num;
            for (int r=1; r<=line; r++)
            {
               

            }
        }
    }
}
