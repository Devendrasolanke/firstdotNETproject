using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.CallByValueAndRef
{
    class CallByValue
    {
        static void Method1(int a, int b)
        {
            int swap = a;
            a = b;
            b = swap;
            Console.WriteLine($"a={a} and b={b}");
        }
        static void Main(string[] args)
        {
            int a = 20, b = 30;
            Method1(a,b);
            Console.WriteLine("After Swapping value of a & b veriables with call by value");
            Console.WriteLine($"{a},{b}");
        }
    }
    class CallByRef
    {
        static void Method2(ref int a, ref int b)
        {
            int swap = a;
            a = b;
            b = swap;
        }
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            Console.WriteLine("Before swapping the values a & b");
            Console.WriteLine($"a={a}, b{b}");
            Method2(ref a,ref b);
            Console.WriteLine("After swapping values of a & b variables with call by ref");
            Console.WriteLine($"a={a}, b={b}");
        }
    }
   
}
