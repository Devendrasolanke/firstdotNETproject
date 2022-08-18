using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Loops
{
    class AllMethods
    {
        public void Show()
        {
            Console.WriteLine("In This Program We See The Four Types of Methods\n1. No Return Type No Parameter\n2. No Return Type With Parameter\n3. With Return Type No Parameter\n4. With Return Type and Parameter");
        }


        public bool IsPrime(int num)
        {
            bool flag = true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    flag = false;
                }
            }
            if (flag == true)
                return true;
            else
                return false;

        }

        public int SumDigit(int n)
        {
            int copy = n;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {

                int r = n % 10;
                sum = sum + r;
                n = n / 10;
            }
            return sum;

        }

        public int CubeSumOfDigit(int Num)
        {
            int cube = 0;
            int cpy = Num;
            for (int i = 1; i <= Num; i++)
            {
                int r = Num % 10;
                cube = cube + (r * r * r);
                Num = Num / 10;
            }
            return cube;

        }

        public int AvgOfDigits(int num1)
        {
            int c=0;
            int cube = 0;
            int cpy = num1;
            for (int i = 1; i <= num1; i++)
            {
                int r = num1 % 10;
                cube = cube + r;
                num1 = num1 / 10;
                c = cube / i;
                
            }
            return c;

        }
        static void Main(string[] args)
        {
            AllMethods s = new AllMethods();
            s.Show();

            Console.WriteLine("Enter The Number For Find Out Number Is Prime OR Not Prime");
            int num = int.Parse(Console.ReadLine());
            bool flag = s.IsPrime(num);
            if (flag == true)
                Console.WriteLine("The Number Is Prime");
            else
                Console.WriteLine("The Number Is Not Prime");

            Console.WriteLine("Enter The Numbers For Sum Of The Digits");
            int n = int.Parse(Console.ReadLine());
            int sum = s.SumDigit(n);
            Console.WriteLine($"The Sum Of Digits This Number Is {sum}");

            Console.WriteLine("Enter The Number For Cube Of Sum Of The Digits");
            int Num = int.Parse(Console.ReadLine());
            int cube = s.CubeSumOfDigit(Num);
            Console.WriteLine($"The Cube Of Sum Of Digits This Number Is {cube}");

            Console.WriteLine("Enter The Number For Find Out The Average Of Digits");
            int num1 = int.Parse(Console.ReadLine());
            int c= s.AvgOfDigits(num1);
            Console.WriteLine($"The Average Of Digits Is {c}");


        }
    }
}
