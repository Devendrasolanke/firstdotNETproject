using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.OopsConcepts
{
    class Calculator
    {
        static int a, b, c;
        void Readdata()
        {
            Console.WriteLine("Enetr the two numbers");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
        }
        int Add()
        {
            c = a + b;
            return c;
        }
        void Sub()
        {
            c = a - b;
            Console.WriteLine("Subtraction is " + c);
        }
        int Mul()
        {
            c = a * b;
            return c;
        }
        float Div()
        {
            c = a / b;
            return c;
        }
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.Readdata();
            int sum = c.Add();
            c.Sub();
            int pro = c.Mul();
            float d = c.Div();
            Console.WriteLine("Sum " + sum);
            Console.WriteLine("Product " + pro);
            Console.WriteLine("Division " + d);
        }
    }
}
