using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Arrays
{
    class ArrayInput
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("Enter the 5 elements");
            for(int i=0; i<5; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0; i<5; i++)
            {
                Console.WriteLine("Data = "+a[i]);
            }
            /*for(int i=9; i>=0; i--)
            {
                Console.WriteLine("Data = "+a[i]);
            }*/
        }
    }
    class ArrayString
    {
        static void Main(string[] args)
        {

        }
    }
    class OddAndEven
    {
        static void Main(string[] args)
        {
            int evenc = 0, oddc=0;
            int[] arr = new int[10];
            Console.WriteLine("Enter 10 Numbers");
            for(int i = 0; i < 10; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0; i<10; i++)
            {
                if (i % 2 == 0)
                {
                    evenc++;
                    Console.WriteLine("Even Numbers : "+i);
                }
                else
                {
                    oddc++;
                    Console.WriteLine("Odd Numbers : "+i);
                }

            }
            Console.WriteLine("Even Numbers : "+evenc);
            Console.WriteLine("Odd Numbers : "+oddc);
        }
    }
    class ArrDivFive
    {
        static void Main(string[] args)
        {
                      
            Console.WriteLine("Enter the size of array");
            int s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            Console.WriteLine($"Enter the {arr.Length} elements");
            for (int i=0; i<arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] % 5 == 0)
                {
                    Console.WriteLine("The Number which is divisible by five is : "+arr[i]);
                    arr[i] = arr[i] + 5;
                    Console.WriteLine("The Number which is divisible by five increase by five : "+arr[i]);
                }
            }
        }
    }
}
