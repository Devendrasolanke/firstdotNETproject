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
            int x = 20, y = 30;
            Method1(x,y);
            Console.WriteLine($"{x},{y}");
        }
    }
    class CallByRef
    {
        static int Method2(ref int a, ref int b)
        {
            int c = a + b;
            return c;
        }
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            int c=Method2(ref a,ref b);
            Console.WriteLine(c);
        }
    }
   
}
