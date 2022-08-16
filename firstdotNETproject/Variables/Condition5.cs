using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Variables
{
    class Condition5
    {
        //  He/she Teenager or not
        static void Main(String[] args)
        {
            int y, z, Age;
            Console.WriteLine("Enter Todays Year");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Year of Birth");
            z = int.Parse(Console.ReadLine());
            Age = y - z;
            
            if (Age <= 18)
            {
                Console.WriteLine("You are Teenager");
            }
            else
            {
                Console.WriteLine("You are not Teenager");
            }
            Console.WriteLine("And");
            Console.WriteLine("Your Age is " + Age);

        }
    }
}
