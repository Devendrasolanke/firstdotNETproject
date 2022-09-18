using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Arrays
{
    class RandomMerg
    {
        static void PrintArr(int[] a)
        {
            for(int i=0; i<a.Length; i++)
            {
                Console.Write(a[i]+" ");
            }
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] b = { 4, 3, 2, 5 };
            int[] c = new int[a.Length + b.Length];
            int k = 0;
            for (int i=0; i<c.Length;)
            {
                if(k<a.Length && k < b.Length)
                {
                    c[k] = a[i];
                    k++;
                    c[k] = b[i];
                    k++;
                }
                else if (k < a.Length)
                {
                    c[k] = a[i];
                    k++;
                }
                else if (k < b.Length)
                {
                    c[k] = b[i];
                    k++;
                }
                i++;
            }
            PrintArr(c);
        }
    }
    class AddNdPrint
    {
        static void PrintArr(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Array Size You Wants");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Now Enter The Array Elements");
            int[] arr = new int[s];
            for (int i=0; i<s; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            PrintArr(arr);
        }
    }
    class CalAvg
    {
        static void PrintArr(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Array Size You Wants");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Now Enter The Array Elements");
            int[] arr = new int[s];
            for (int i = 0; i < s; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            for (int i=0; i<arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine($"Sum of All Array Elements is : {sum}");
            Console.WriteLine($"The Elements Available in Array are : {s}");
            Console.WriteLine($"Avg of the Array is : {sum/s}");
        }
    }
    class PrintIndex
    {
        public static void PrintArr(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Array Size You Wants");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Number for Search in Array");
            int SNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Now Enter The Array Elements");
            int[] arr = new int[s];
            int count = 0, k=0;
            for (int i = 0; i < s; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

        }
    }
    class CopyNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Array Size You Wants");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Now Enter The Array Elements");
            int[] arr = new int[s];
            int[] cpy = new int[s];
            for (int i = 0; i < s; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i=0; i<s; i++)
            {
                cpy[i] = arr[i];
            }
            PrintIndex.PrintArr(cpy);
        }
    }
    class PrintRev
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Array Size You Wants");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Now Enter The Array Elements");
            int[] arr = new int[s];
            int[] reverse = new int[s];
            int[] alter = new int[s];
            for (int i = 0; i < s; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Reverse Array Elemnts");
            
            for (int i=s-1; i>=0; i--)
            {
                reverse[i] = arr[i];
                Console.Write(reverse[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Reverse Alternate Numbers");
            for (int i=s-1; i>=0; i--)
            {
                if (i % 2 == 0)
                {
                    alter[i] = arr[i];
                    Console.Write(alter[i]+" ");
                }
            }
        }
    }
    class AvgArray
    {
        public static int Average(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine($"Sum of All Array Elements is : {sum}");
            return sum;
        }
        public static double Average(double[] a)
        {
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine($"Sum of All Array Elements is : {sum}");
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Array Size You Wants");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Now Enter The Array Elements");
            int[] arr = new int[s];
            for (int i = 0; i < s; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int intAvg = Average(arr);
            Console.WriteLine($"The Array Average of int Average Method is : {intAvg/s}");

            Console.WriteLine("Enter The Array Size You Wants");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Now Enter The Array Elements");
            int[] arr2 = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }

            double doubleAvg = Average(arr2);
            Console.WriteLine($"The Array Average of double Average Method is : {doubleAvg/size}");
        }
    }
    class NegArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Array Size You Wants");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Now Enter The Array Elements");
            int[] arr = new int[s];
            for (int i = 0; i < s; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int count = 0, k=0;
            for (int i=0; i<s; i++)
            {
                if (arr[i] >= 0)
                {
                    continue;
                }
                else
                {
                    count++;
                }
            }
            int[] Neg = new int[count];
            for (int i=0; i<s; i++)
            {
                if (arr[i] >= 0)
                {
                    continue;
                }
                else
                {
                    Neg[k] = arr[i];
                    k++;
                }
                
            }
            Console.WriteLine($"Negative Numbers in Array is : {count}");
            Console.WriteLine("Negative Numbers are Below");
            PrintIndex.PrintArr(Neg);
        }
    }
    class OddEvenArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Array Size You Wants");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Now Enter The Array Elements");
            int[] arr = new int[s];
            for (int i = 0; i < s; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int OddCount = 0, EvenCount = 0;
            for (int i = 0; i < s; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    EvenCount++;
                }
                else
                {
                    OddCount++;
                }
            }

            int[] Odd = new int[OddCount];
            int[] Even = new int[EvenCount];
            int E = 0, O=0;
            for (int i=0; i<s; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Even[E] = arr[i];
                    E++;
                }
                else
                {
                    Odd[O] = arr[i];
                    O++;
                }
            }
            Console.WriteLine("Even Numbers in Array are :");
            PrintIndex.PrintArr(Even);
            Console.WriteLine();
            Console.WriteLine("Odd Numbers in Array are :");
            PrintIndex.PrintArr(Odd);
        }
    }
    class MaxMinNumArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Array Size You Wants");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Now Enter The Array Elements");
            int[] arr = new int[s];
            for (int i = 0; i < s; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int max = 0, min=arr[0];
            for(int i=0; i<s; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"Max Value in Array is : {max}");
            Console.WriteLine($"Min Value in Array is : {min}");
        }
    } 
    class DuplicateNum
    {
        static bool IsAlreadyPresent(int[] a, int pos)
        {
            for(int i=0; i<pos; i++)
            {
                if (a[i] == a[pos])
                {
                    return true;
                }
            }
            return false;
        }
        static void CalDuplicates(int[] a, int count)
        {
            for (int i=0; i<a.Length; i++)
            {
                if (IsAlreadyPresent(a, i) == false)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"Frq of {a[i]} is : {count}");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Array Size You Wants");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Now Enter The Array Elements");
            int[] arr = new int[s];
            
            for (int i = 0; i < s; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int count = 0;
            CalDuplicates(arr, count);
        }
    }
    class PosNegMerg
    {
        static void PosNeg(int[] a)
        {
            int pc = 0, nc=0;
            for (int i=0; i<a.Length; i++)
            {
                if (a[i] >= 0)
                {
                    pc++;
                }
                else
                {
                   nc++;
                }
            }
            int[] neg = new int[nc];
            int[] other = new int[pc];
            nc = 0;
            pc = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= 0)
                {
                    other[pc] = a[i];
                    pc++;
                }
                else
                {
                    neg[nc] = a[i];
                    nc++;
                }
            }
            int[] merg = new int[pc + nc];
            nc = 0;
            for (int i=0; i<merg.Length; i++)
            {
                if (i<other.Length && i < neg.Length)
                {
                    merg[nc] = neg[i];
                    nc++;
                    merg[nc] = other[i];
                    nc++;
                }
                else  if (i < other.Length)
                {
                    merg[nc] = other[i];
                    nc++;
                }
                else if (i < neg.Length)
                {
                    merg[nc] = neg[i];
                    nc++;
                }
            }

            Print<int>.MyArray(merg);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the  size of array");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter array elements");
            for(int i=0; i<size; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            PosNeg(a);
        }
    }
}
