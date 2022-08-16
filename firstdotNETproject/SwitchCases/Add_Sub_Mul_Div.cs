using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.SwitchCases
{
    class Add_Sub_Mul_Div
    {
        static void Main(string[] args)
        {
            int num1, num2, option;
            Console.WriteLine("Enter The First Number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Second Number");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Press Below Option To Perform Any Operation\n1.Addition\n2.Subtraction\n3.Multiplication\n4.Division");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: Console.WriteLine($"Addition Of Given Two Numbers = {num1 + num2}");
                    break;
                case 2: Console.WriteLine($"Subtraction Of Given Two Numbers = {num1 - num2}");
                    break;
                case 3: Console.WriteLine($"Multiplication Of Given Two Numbers = {num1 * num2}");
                    break;
                case 4: Console.WriteLine($"Division Of Given Two Numbers = {num1 / num2}");
                    break;
            }
        }
    }
}
