using System;

namespace firstdotNETproject.Variables
{
    class Positive_Or_Nigative
    {
        //Number is positive or nigative
        static void Main(String[] args)
        {
            Console.WriteLine(" Enter the Number");
            int num = int.Parse(Console.ReadLine());

            if (num>0.0)
            {
                Console.WriteLine("Num is positive");
            }
            else
            {
                Console.WriteLine("Num is nigative");
            }
        }
    }
}
