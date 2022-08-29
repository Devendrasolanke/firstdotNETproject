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
            
        }
    }
}
