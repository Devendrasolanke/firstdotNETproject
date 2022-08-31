using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.OopsConcepts
{
    class CheckDisarium
    {
        bool IsCheck(int num)
        {
            int copynum = num, r, rem, ctr=0;
            double res = 0;
            while(num>0)//135//13//1//fail
            {
                rem = num % 10;//5//3//1
                num = num / 10;//13//1//0
                ctr++;//1//2//3
            }
            Console.WriteLine("Length of Number "+ctr);
            
            while (num>0)//135//13//1//fail
            {
                    r = num % 10;//5//3//1
                    res = Math.Pow(r,ctr);//5^3=125//3^2=9//1^1=1
                if (ctr > 1)
                {
                    ctr--;//2//1//fail
                }
                    num = num / 10;//13//1//0
            }
            
            if (copynum == res)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            CheckDisarium c1 = new CheckDisarium();
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            bool result=c1.IsCheck(num);
            if (result == true)
            {
                Console.WriteLine("This is Disarium Number");
            }
            else
            {
                Console.WriteLine("This is Not Disarium Number");
            }
        }
    }
}
