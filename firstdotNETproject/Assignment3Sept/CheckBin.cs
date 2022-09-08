using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Assignment3Sept
{
   
    class CheckBin
    {
        bool flag;
        void Binery(int num)
        {
            int r;
            
            while (num > 0)
            {
                r = num % 10;
                if (r == 1 || r == 0)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
                num = num / 10;
            }
            if (flag == true)
            {
                Console.WriteLine("Binery");
            }
            else
            {
                Console.WriteLine("Not Binery");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Binery Number");
            int num = int.Parse(Console.ReadLine());
            CheckBin bo = new CheckBin();
            bo.Binery(num);
            
        }
    }
}
