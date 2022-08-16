using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Variables
{
    class Find_Gain
    {
        static void Main(string[] args)
        {
            float Gain, Sell, Buy;
            Console.WriteLine("Enter Buying Price In Rupees");
            Buy = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Selling Price In Rupees");
            Sell = int.Parse(Console.ReadLine());
            Gain = Sell - Buy;
            Console.WriteLine($"Total Profite Is {Gain} Rupees");
        }
    }
}
