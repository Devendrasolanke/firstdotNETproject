using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.OopsConcepts
{
    class NumPrimeOrNot
    {
        bool flag = true;
        bool IsPrime(int num)
        {
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

       void Display()
        {
            bool isprime = true;
            Console.WriteLine("Prime Numbers ");
            for (int i=2;i<=500; i++)
            {
                for (int j=2;j<=500; j++)
                {
                    if (i!=j && i % j == 0)
                    {
                        isprime = false;
                    }
                }
                if (isprime == true)
                {
                    Console.Write("\t"+i);
                }
                isprime = true;
            }
        }
        static void Main(string[] args)
        {
            NumPrimeOrNot Obj = new NumPrimeOrNot();
            Console.WriteLine("Enter the number to check prime or not");
            int num = int.Parse(Console.ReadLine());
            bool check=Obj.IsPrime(num);
            if (check == true)
            {
                Console.WriteLine("This is prime number");
            }
            else
            {
                Console.WriteLine("This not prime number");
            }
            Obj.Display();
        }
    }
}
