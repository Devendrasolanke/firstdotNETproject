using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Interface
{
    interface Icecream
    {
        void Eat();
    }
    interface Juice
    {
        void Drink();
    }
    class Mastani : Icecream, Juice
    {
        public void Drink()
        {
            Console.WriteLine("Drink Mastani Juice");
        }

        public void Eat()
        {
            Console.WriteLine("Eat Mastani Icecream");
        }
    }
    class TestMastani
    {
        static void Main(string[] args)
        {
            Mastani m = new Mastani();
            m.Drink();
            m.Eat();
        }

    }

}
