using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Loops
{
    class MagicNum
    {
        static void Main(string[] args)
        {
            
            int magicnum = 45;
            while (true)
            {
                Console.WriteLine("Enter The Number");
                int num = int.Parse(Console.ReadLine());
                if (magicnum > num)
                {
                    Console.WriteLine("The Number Is Less.....");
                    continue;
                }
                else if (magicnum < num)
                {
                    Console.WriteLine("the Number Is Greater......");
                    continue;
                }
                else
                {
                    Console.WriteLine("This Is Magical Number");
                    break;
                }
            }
        }
    }
}
