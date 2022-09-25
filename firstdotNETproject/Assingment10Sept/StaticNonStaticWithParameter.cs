using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Assingment10Sept
{
    class StaticNonStaticWithParameter
    {
        static void Method1()
        {
            Console.WriteLine("This is static method with no parameter");
        }
        static void Method2(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("This is static method with parameter");
        }
        void Method3()
        {
            Console.WriteLine("This is non static method with no parameter");
        }
        int Method4(int a, int b)
        {
            return a + b;
            Console.WriteLine("This is non static method with parameter and return type");
        }
        public StaticNonStaticWithParameter()
        {
            Console.WriteLine("This is default constructor, it is automatically called when object is created");
        }
        static void Main(string[] args)
        {
            Method1();
            int a = 12, b = 13;
            Method2(a, b);
            StaticNonStaticWithParameter s = new StaticNonStaticWithParameter();
            s.Method3();
            s.Method4(a, b);
        }
    }
    class StaticConstructor
    {
        static StaticConstructor()
        {
            Console.WriteLine("this is static constructor");
        }
        static void Main(string[] args)
        {

        }
    }
}
