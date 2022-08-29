using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.OopsConcepts
{
    class TrueArg
    {
       
        static void Main(string[] args)
        {
            TrueArg t = new TrueArg();
            int num2;
            Console.WriteLine("Enter The Number");
            num2 = int.Parse(Console.ReadLine());
            bool check = t.IsEven(num2);
            Console.WriteLine("Method Check " + check);
        }
        bool IsEven(int num2)
        {
            if (num2 % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
