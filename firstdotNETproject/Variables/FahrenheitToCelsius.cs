using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Variables
{
    class FahrenheitToCelsius
    {
        static void Main(string[] args)
        {
            float Fahrenheit, Celsius;
            Console.WriteLine("Enter the Temperature");
            Fahrenheit = int.Parse(Console.ReadLine());
            Celsius = 5 * (Fahrenheit - 32) / 9;
            Console.WriteLine($"Celsius is {Celsius}");

        }
    }
}
