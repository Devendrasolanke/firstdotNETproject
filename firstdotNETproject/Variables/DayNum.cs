using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Variables
{
    class DayNum
    {
        //Program int type in between 1 to 7 as day number
        static void Main(String[] args)
        {
            Console.WriteLine(" Enter the Number");
            int num = int.Parse(Console.ReadLine());

            if (num == 1)
            {
                Console.WriteLine("first day is MON");
            }
            else if (num == 2)
            {
                Console.WriteLine("seconde day is TUE");
            }
            else if (num == 3)
            {
                Console.WriteLine("third day is WED");
            }
            else if (num == 4)
            {
                Console.WriteLine("forth day is THU");
            }
            else if (num == 5)
            {
                Console.WriteLine("fifth day is FRI");
            }
            else if (num == 6)
            {
                Console.WriteLine("sixth day is SAT");
            }
            else if (num == 7)
            {
                Console.WriteLine("seventh day is SUN");
            }
            else
            {
                Console.WriteLine("Invalid Entry");
            }
        }
    }
}
