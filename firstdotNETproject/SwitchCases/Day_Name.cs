using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.SwitchCases
{
    class Day_Name
    {
        static void Main(string[] args)
        {
            int option;
            Console.WriteLine("Enter Number To Find Day Name");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: Console.WriteLine("This Is Mon");
                    break;
                case 2: Console.WriteLine("This Is Tue");
                    break;
                case 3: Console.WriteLine("This Is Wed");
                    break;
                case 4: Console.WriteLine("This Is Thu");
                    break;
                case 5: Console.WriteLine("This Is Fri");
                    break;
                case 6: Console.WriteLine("This Is Sat");
                    break;
                case 7: Console.WriteLine("This Is Sun");
                    break;
            }
        }
    }
}
