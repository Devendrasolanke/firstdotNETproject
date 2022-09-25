using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Arrays
{
    class TDarray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter row size");
            int rs = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter col size");
            int cs = int.Parse(Console.ReadLine());
            int[,] a = new int[rs, cs];
            for (int r=0; r<a.GetLength(0); r++)
            {
                Console.WriteLine($"Enter Elment {r} row");
                for (int c=0; c<a.GetLength(1); c++)
                {
                    a[r, c] = int.Parse(Console.ReadLine());
                }
            }
            
            for (int r = 0; r < a.GetLength(0); r++)
            {
                for (int c = 0; c < a.GetLength(1); c++)
                {
                    Console.Write(a[r, c]+" ");
                }
                Console.WriteLine();
            }
        }
    }
    class MaxNum
    {
        static  void FindMaxPerCol(int[,] a)
        {
            for (int c=0; c<a.GetLength(1); c++)
            {
                int max = int.MinValue;
                for (int r=0; r<a.GetLength(0); r++)
                {
                    if (a[r,c] > max)
                        max = a[r,c];
                }
                Console.Write($"Max Value in {c}st col : "+max);
                Console.WriteLine();
            }
        }
        static void FindMaxPerRow(int[,] a)
        {
            for (int r=0; r<a.GetLength(0); r++)
            {
                int max = int.MinValue;
                for (int c=0; c<a.GetLength(1); c++)
                {
                    if (a[r, c] > max)
                        max = a[r, c];
                }
                Console.Write($"Max Value in {r}st row : "+max);
                Console.WriteLine();
            }
        }
        static void FindMax(int[,] a)
        {
            int max = int.MinValue;
            for (int r=0; r<a.GetLength(0); r++)
            {
                for (int c=0; c<a.GetLength(1); c++)
                {
                    if(a[r,c] > max)
                    {
                        max = a[r,c];
                    }
                }
            }
            Console.WriteLine("Max Number in whole array : "+max);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the row size");
            int rs = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the col size");
            int cs = int.Parse(Console.ReadLine());
            int[,] a = new int[rs, cs];
            for (int r=0; r<rs; r++)
            {
                Console.WriteLine($"Enter {r}st row elemets");
                for (int c=0; c<cs; c++)
                {
                    a[r, c] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("=============================================");
            FindMax(a);
            Console.WriteLine("=============================================");
            FindMaxPerRow(a);
            Console.WriteLine("=============================================");
            FindMaxPerCol(a);
        }
    }
    class SumArray
    {
        static void ColSum(int[,] a)
        {
            int sum = 0;
            for (int c = 0; c < a.GetLength(1); c++)
            {
                
                for (int r = 0; r < a.GetLength(0); r++)
                {
                    sum = sum + a[r, c];
                }
                Console.WriteLine("Total Sum of Col in Array : " + sum);
            }
        }
        static void RowSum(int[,] a)
        {
            
            for (int r = 0; r < a.GetLength(0); r++)
            {
                int sum = 0;
                for (int c = 0; c < a.GetLength(1); c++)
                {
                    sum = sum + a[r, c];
                }
                Console.WriteLine("Total Sum of Row in Array : " + sum);
            }
        }
        static void Sum(int[,] a)
        {
            int sum = 0;
            for (int r = 0; r < a.GetLength(0); r++)
            {
                for (int c = 0; c < a.GetLength(1); c++)
                {
                    sum = sum + a[r, c];
                }
            }
            Console.WriteLine("Total Sum of Array : "+sum);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the row size");
            int rs = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the col size");
            int cs = int.Parse(Console.ReadLine());
            int[,] a = new int[rs, cs];
            for (int r = 0; r < rs; r++)
            {
                Console.WriteLine($"Enter {r}st row elemets");
                for (int c = 0; c < cs; c++)
                {
                    a[r, c] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("========================================");
            Sum(a);
            Console.WriteLine("========================================");
            RowSum(a);
            Console.WriteLine("========================================");
            ColSum(a);
            Console.WriteLine("========================================");
        }
    }
    class DigonalArray
    {
        static void RightDigonal(int[,] a)
        {
            int b = 0, d=a.GetLength(1)-1;
            for (int r = 0; r < a.GetLength(0); r++)
            {
                for (int c = 0; c < a.GetLength(1); c++)
                {
                    if (a[r, c] == a[b, d])
                    {
                        Console.Write(a[r, c]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                b++;
                d--;
                Console.WriteLine();
            }
        }
        static void LeftDigonal(int[,] a)
        {
            int b = 0;
            for (int r = 0; r < a.GetLength(0); r++)
            {
                for (int c = 0; c < a.GetLength(1); c++)
                {
                    if (a[r, c] == a[b, b])
                    {
                        Console.Write(a[r,c]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                b++;
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the row size");
            int rs = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the col size");
            int cs = int.Parse(Console.ReadLine());
            int[,] a = new int[rs, cs];
            for (int r = 0; r < rs; r++)
            {
                Console.WriteLine($"Enter {r}st row elemets");
                for (int c = 0; c < cs; c++)
                {
                    a[r, c] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("======Left Digonal======");
            LeftDigonal(a);
            Console.WriteLine("======Right Digonal======");
            RightDigonal(a);
        }
    }
}
