using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Arrays
{
    static class Print<t>
    {
        public static void MyArray( t[] a)
        {
            for (int i=0; i<a.Length; i++)
            {
                Console.Write(" "+a[i]);
            }
        }
    }
    class PairOfSumArray
    {
        static void SumOfArray(int[] a, int sum)
        {
            for (int i=0; i<a.Length; i++)
            {
                for (int j=i+1; j<a.Length; j++)
                {
                    if(a[i] +  a[j] == sum)
                    {
                        Console.WriteLine($"{a[i]} and {a[j]}");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter elements in array");
            for(int i=0; i<size; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the element for result is sum");
            int Add = int.Parse(Console.ReadLine());

            SumOfArray(a, Add);
        }
    }

    class PairPrimeWithEven
    {
        static bool Check(int k)
        {
            bool flag = true;
            for (int i=2; i<=k/2; i++)
            {
                if (k % i == 0)
                {
                    flag = false;
                }
            }
            return flag;
        }
        static void Pair(int[] a)
        {
            int c = 0;
            
            for (int i=0; i<a.Length; i++)
            {
               if (Check(a[i])==true)
                {
                    c++;
                }
               
            }
            int[] prime = new int[c];
            c = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (Check(a[i]) == true)
                {
                    prime[c] = a[i];
                    c++;
                }
            }
            Print<int>.MyArray(prime);
            
            c = 0;
            for (int i=0; i<a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    c++;
                }
            }
            int[] even = new int[c];
            c = 0;
            for (int i=0; i<a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    even[c] = a[i];
                    c++;
                }
            }
            Print<int>.MyArray(even);

            int[] merg = new int[prime.Length + even.Length];
            c = 0;
            for (int i=0; i<merg.Length; i++)
            {
                if(i < prime.Length && i < even.Length)
                {
                    merg[c] = prime[i];
                    c++;
                    merg[c] = even[i];
                    c++;
                }
                else if (i < prime.Length)
                {
                    merg[c] = prime[i];
                    c++;
                }
                else if (i < even.Length)
                {
                    merg[c] = even[i];
                    c++;
                }
            }
            Console.WriteLine();
            Print<int>.MyArray(merg);
           
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter elements in array");
            for (int i = 0; i < size; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            Pair(a);
        }
    }
}
