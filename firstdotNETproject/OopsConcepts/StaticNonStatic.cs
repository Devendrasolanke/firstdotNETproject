using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.OopsConcepts
{
    static class StaticNonStatic
    {
        static int a=10, b=20, sum, sub;
        static void Addition()
        {
            sum = a + b;
            Console.WriteLine("Addition : "+sum);
        }
        static void Main(string[] args)
        {
            StaticNonStatic.Addition();
            StaticNonStatic.Subtraction();
        }
        static void Subtraction()
        {
            sub = a - b;
            Console.WriteLine("Subtraction : "+sub);
        }
    }
    class NonStatic
    {
        static int a = 30, b = 40;
        static int sum, sub, mul, div;
        void Addition()
        {
            sum = a + b;
            Console.WriteLine("Addition : "+sum);
        }
        void Subtraction()
        {
            sub = a - b;
            Console.WriteLine("Subtraction : "+sub);
        }
        static void Multiplication()
        {
            mul = a * b;
            Console.WriteLine("Multiplication : "+mul);
        }
        static void Division()
        {
            div = a / b;
            Console.WriteLine("Division : "+div);
        }
        static void Main(string[] args)
        {
            NonStatic N = new NonStatic();
            N.Addition();
            N.Subtraction();
            NonStatic.Multiplication();
            NonStatic.Division();
        }
    }
   
}
