using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.MockQuestions
{
    class SumOfPrime
    {
        static bool IsCheckPrime(int p)
        {
            for (int i=2; i<p/2; i++)
            {
                if (p % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void SumOfPrimeNum(int p)
        {
            int r, sum=0;
            while (p > 0)
            {
                r = p % 10;
                if (IsCheckPrime(r))
                {
                    sum = sum + r;
                }
                p = p / 10;
            }
            Console.WriteLine("Sum of Prime Numbers : "+sum);
        }
        static void SumOfPrimeInArray(int[] a)
        {
            int sum = 0;
            for(int i=0; i<a.Length; i++)
            {
                if (IsCheckPrime(a[i]))
                {
                    sum = sum + a[i];
                }
            }
            Console.WriteLine("Sum of Prime Number in Array is : "+sum);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int prime = int.Parse(Console.ReadLine());
            SumOfPrimeNum(prime);
            int[] a = new int[5];
            Console.WriteLine($"Enter {a.Length} elements");
            for(int i=0; i<a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            SumOfPrimeInArray(a);
        }
    }
}
