using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.OopsConcepts
{
    class TimeShow
    {
        int h, m, s;
        void SetTime(int hour, int minute, int second)
        {
            h = hour;
            m = minute;
            s = second;
        }

        void ShowTime()
        {
            Console.WriteLine("Time is " + h + ": " + m + " :" + s);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Set time\nhour\nminute\nsecond");
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            TimeShow t = new TimeShow();
            t.SetTime(hour, minute, second);
            t.ShowTime();

        }
    }
}
