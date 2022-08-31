using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.OopsConcepts
{
    class PawOfNum
    {
        int Result=1;
        int Power(int BaseNum, int Expo)
        {
            for (int i=1; i<=Expo; i++)
            {
                Result = Result * BaseNum;
            }
            return Result;
        }
        static void Main(string[] args)
        {
            PawOfNum p1 = new PawOfNum();
            Console.WriteLine("Enter\nBase of Number\nExponantial of Number");
            int b = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int res=p1.Power(b, e);
            Console.WriteLine($"Power of {b}^{e} is {res}");
        }
    }
}
