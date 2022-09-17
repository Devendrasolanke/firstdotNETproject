using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Loops
{
    class IsTwinPrime
    {
        public bool IsPrime(int num)
        {
            bool flag = true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    flag = false;
                    
                }
            }
            if (flag == true)
            {
                    return true;
             }
            else
             {
                    return false;
             }
            
        }
        public static void Main(string[] args)
        {
            IsTwinPrime Ob = new IsTwinPrime();
            Console.WriteLine("Enter The First Number");
            int num1 = int.Parse(Console.ReadLine());
            bool n1 = Ob.IsPrime(num1);
            Console.WriteLine("Enter The Second Number");
            int num2 = int.Parse(Console.ReadLine());
            bool n2=Ob.IsPrime(num2);
            if (n1== true && n2 == true)
            {
                if (num1 - num2 == 2 || num1 - num2 == - 2)
                {
                    Console.WriteLine("This Is Twin Prime Numbers");
                }
                else
                {
                    Console.WriteLine("Both Numbers Are Prime But Not Twins");
                }
            }
            else
            {
                Console.WriteLine("Numbers Are Not Prime");
            }
               

        }
    }
    class fibbo
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int a = 0, b = 1, sum;
            for (int i=0; i<10; i++)
            {
                sum = a + b;
                Console.WriteLine(a);
                arr[i] = a;
                a = b;
                b = sum;
            }
            
        }
    }
}
