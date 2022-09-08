using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Loops
{
    class Fibonnaci
    {
        
        static void Main(string[] args)
        {
            int prev = 0, next = 1, sum;
            for(int i=1; i<=10; i++)
            {
                sum = prev + next;
                Console.Write("\t"+sum);
                prev = next;
                next = sum;
            }
            
        }
    }

    class Fibonnaci2
    {
        
        static void Main(string[] args)
        {
            int bse, expo, ans;
            for (bse = 1; bse <= 10; bse++)
            {
                for (expo = bse; expo <= bse; expo++)
                {
                    ans = bse * expo;
                    Console.Write("\t"+ans);
                }
                
            }
        }
    }

    class Fibonnaci3
    {
        static void Main(string[] args)
        {
            int bse, expo, ans;
            for (bse = 1; bse <= 10; bse++)
            {
                for (expo = bse; expo <= bse; expo++)
                {
                    ans = bse * expo;
                    ans = ans - 1;
                    Console.Write("\t" + ans);
                } 

            }
        }
    }
}
