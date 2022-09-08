using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Inheritance
{
    class P
    {
        int i;
        public P()
        {
            Console.WriteLine("Default Constructor in Parent class");
        }
        public P(int i)
        {
            Console.WriteLine("Parameterize constructor in Parent class");
        }
    }
    class C:P
    {
        
        string Name;
        public C()
        {
            Console.WriteLine("Default Constructor in child class");
        }
        public C(int i, string Name) : base(i)
        {
            Console.WriteLine("Parameterize constructor in child class");
        }
    }
    class Test1
    {
        static void Main(string[] args)
        {


            C c = new C(123, "devendra");
        }
    }
}
