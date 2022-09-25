using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Arrays
{
    class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] a = new int[3][];
            
            for(int i=0; i<a.GetLength(0); i++)
            {
                Console.WriteLine($"Enter the column {i}th row");
                int c = int.Parse(Console.ReadLine());
                a[i] = new int[c];
            }
            for (int i=0; i<a.GetLength(0); i++)
            {
                Console.WriteLine($"Enter the {i}th row elements");
                for(int j=0; j<a[i].Length; j++)
                {
                    a[i][j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
  