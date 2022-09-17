using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Arrays
{
    static class PrintArray<t>
    {
        public static void Print(t[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        public static void PrintRev(t[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
    class DuplicatNum
    {
        static bool IsAlreadyP(int[] arr, int currentPos)
        {
            for (int i = 0; i < currentPos; i++)
            {
                if (arr[i] == arr[currentPos])
                {
                    return true;
                }
            }
            return false;
        }
        static void FindFrq(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                if (IsAlreadyP(arr, i) == false)
                {
                    int count = 1;
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"frequency of {arr[i]} is : {count}");
                }

            }
        }
        static void UniqNum(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsAlreadyP(arr, i) == false)
                {
                    count = 1;
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                        }
                    }
                }
                if (count == 1)
                {
                    Console.WriteLine($"Unique Numbers is : {arr[i]}");
                }
            }
        }
        static void DupliNum(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsAlreadyP(arr, i) == false)
                {
                    int c = 0;
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            c++;
                        }
                    }
                    if (c > 0)
                    {
                        Console.WriteLine($"Duplicate Number {arr[i]} and count is {c}");
                    }
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
            Console.WriteLine("==============================================");
            FindFrq(arr);
            Console.WriteLine("==============================================");
            UniqNum(arr);
            Console.WriteLine("==============================================");
            DupliNum(arr);
        }
    }
    class SecondSmall
    {

        static void SecSmall(int[] arr)
        {
            int max = int.MinValue;
            int secondMax = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[i] > max)
                    {
                        secondMax = max;
                        max = arr[i];
                    }
                    else if (arr[i] > secondMax && arr[i] != max)
                    {
                        secondMax = arr[i];
                    }
                }
            }
            Console.WriteLine($"Second Max number in array is : {secondMax}");
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

            SecSmall(arr);

        }
    }

    class AscadingOrder
    {
        static void AscadOrder(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int t = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = t;
                    }
                }
            }
            Console.WriteLine("Ascading Order");
            PrintArray<int>.Print(arr);
            Console.WriteLine();
            Console.WriteLine("Descading Order");
            PrintArray<int>.PrintRev(arr);
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

            AscadOrder(arr);
        }
    }
    class NearestElement
    {
        static void FindNear(int[] arr, int k)
        {
            int min = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if ((Math.Abs(k - arr[i])) < (Math.Abs(k - min)))
                {
                    min = arr[i];
                }
            }
            Console.WriteLine(min);
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
            Console.WriteLine("Enter the element to find nearer elements");
            int near = int.Parse(Console.ReadLine());
            FindNear(arr, near);
        }
    }
    class Uncommen
    {
        static void Uncommon(int[] a, int[] b)
        {
            for (int i=0; i<a.Length; i++)
            {
                int c = 0;
                for (int j=0; j<b.Length; j++)
                {
                    if (b[i] == a[j])
                        c++;
                }
                if (c==0)
                    Console.Write("Uncommon element is first array : "+a[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < b.Length; i++)
            {
                int c = 0;
                for (int j = 0; j < a.Length; j++)
                {
                    if (b[j] == a[i])
                        c++;
                }
                if (c == 0)
                    Console.Write("Uncommon element is second array : " + b[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first array size");
            int s = int.Parse(Console.ReadLine());
            int[] a = new int[s];
            Console.WriteLine("Enter the elements");
            for (int i = 0; i < s; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the second array size");
            int s1 = int.Parse(Console.ReadLine());
            int[] a1 = new int[s1];
            Console.WriteLine("Enter the elements");
            for (int i = 0; i < s1; i++)
            {
                a1[i] = int.Parse(Console.ReadLine());
            }

            Uncommon(a, a1);
        }
    }
    class AlternatPosNeg
    {

        static void Main(string[] args)
        {
            int[] a = { 21, -2, 12, 43, -20, -13, 15 };
            int[] b = new int[a.Length];

            for(int i=0; i<a.Length; i++)
            {
                for (int j=0; j<a.Length; j++)
                {
                   
                }
            }
        }
    }
}
