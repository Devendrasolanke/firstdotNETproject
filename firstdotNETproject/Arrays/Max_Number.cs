using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Arrays
{
    class Max_Number
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine($"Enter {arr.Length} Elements In Arrays");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            int Max = arr[0];
            for (int i=1; i < arr.Length; i++)
            {
                if (Max < arr[i])
                {
                    Max = arr[i];
                }
                    
            }
            Console.WriteLine("Max Number Is = " + Max);
        }
    }
}
