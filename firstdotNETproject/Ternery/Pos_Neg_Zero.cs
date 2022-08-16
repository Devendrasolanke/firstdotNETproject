using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Ternery
{
    class Pos_Neg_Zero
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter The Number");
            num = int.Parse(Console.ReadLine());
            string result = num > 0 ? "This Number Is Positive" : num == 0 ? "This Number Is Zero" : "This Number Is Negative";
            Console.WriteLine(result);
        }
    }
}
