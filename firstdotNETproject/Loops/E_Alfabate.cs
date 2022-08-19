using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Loops
{
    class E_Alfabate 
    {
        static void Main(string[] args)
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
    }
}
