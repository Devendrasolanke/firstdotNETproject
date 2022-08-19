using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Loops
{
    class Patterns
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Row");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Coln");
            int c = int.Parse(Console.ReadLine());

            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= c; j++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine();
            }
        }

    }

    class D_Pattern
    {
        public void Dpattern()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if (i == 1 || i == 4 || j == 2 || j == 4)
                    {

                        Console.Write(" *");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            D_Pattern d = new D_Pattern();
            d.Dpattern();

        }
    }

    class O_Pattern
    {
        public void OPattern()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if (i == 5 || i == 1 || j == 1 || j == 4)
                    {
                        Console.Write(" *");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            O_Pattern ob = new O_Pattern();
            ob.OPattern();
        }
    }

    class E_Pattern
    {
        public void Epattern()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    if (j == 1 || i == 1 || i == 5 || i == 9)
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");

                }
                Console.WriteLine();
            }
        }
       static void Main(string[] args)
            {
              E_Pattern e = new E_Pattern();
            e.Epattern();

            }
        
    }

    class EigthPattern
    {
        public void EigthP()
        {
            for (int i=1; i<=5; i++)
            {
                for (int j=1; j<=4; j++)
                {
                    if (i == 1 || i==3 || i==5 || j==1 || j == 4)
                    {
                        Console.Write(" *");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            EigthPattern E = new EigthPattern();
            E.EigthP();
        }
    }

    class Two_Pattern
    {
        public void TwoP()
        {
            for (int i=1; i<=5; i++)
            {
                for (int j=1; j<=4; j++)
                {
                    if (i == 1 || i == 3 || i == 5 || j >= 1 || j <= 3 || j >= 3 || j <= 5)
                    {
                        Console.Write(" *");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Two_Pattern t = new Two_Pattern();
            t.TwoP();

        }
    }
}
