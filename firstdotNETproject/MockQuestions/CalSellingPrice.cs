using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.MockQuestions
{
    class CalSellingPrice
    {
        static void CalSellPrice(int cost, int profit)
        {
            int SellingPrice = cost + (profit / 100) * cost;
            Console.WriteLine("Selling Price Is : "+SellingPrice);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cost price");
            int cost = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter no. of itoms");
            int itom = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the profit");
            int profit = int.Parse(Console.ReadLine());
            CalSellPrice(cost, profit);
        }
    }
}
