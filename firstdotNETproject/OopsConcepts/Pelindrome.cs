using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.OopsConcepts
{
    class Pelindrome
    {
        bool IsCheck(int num)
        {
            int copy = num;
            int r, sum = 0;
            while (num > 0)
            {
                r = num % 10;
                sum = (sum * 10) + r;
                num = num / 10;
            }
            if (copy == sum)
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
            Pelindrome p1 = new Pelindrome();
            Console.WriteLine("Enter the number to check it is pelindrome or not");
            int num = int.Parse(Console.ReadLine());
            bool result=p1.IsCheck(num);
            if (result==true)
                Console.WriteLine("This is pelindrome number");
            else
                Console.WriteLine("This is not pelindrome number");
        }
    }
}
