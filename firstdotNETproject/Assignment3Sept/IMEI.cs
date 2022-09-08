using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Assignment3Sept
{
    class IMEI
    {
       bool IsValidIMEI(long num)
        {
            String s = num.ToString();
            int length = s.Length;
            if (length != 15)
            {
                return false;
            }
            int sum = 0;
            for(int i = length; i >= 1; i--)
            {
                int d = (int)(num % 10);
                if (i % 2 == 0)
                {
                    d = 2 * d;
                }
                num = num / 10;
            }
            return (sum % 10 == 0);
        }
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter The IMEI Number");
            long num = long.Parse(Console.ReadLine());
            IMEI obj = new IMEI();
            bool check = obj.IsValidIMEI(num);
            if (check==true)
                Console.WriteLine("Valid IMEI Number");
            else
                Console.WriteLine("Invaluiid IMEI Number");
        }
    }
}
