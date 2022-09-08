using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Containments
{
    class Pen
    {
        int capLength;
        string brand;
        Refill r;
        Pen()
        {

        }
        public Pen(int capLength, string brand, Refill r)
        {
            this.capLength = capLength;
            this.brand = brand;
            this.r = r;
        }
        static void Main(string[] args)
        {
            Nib n = new Nib("Steel", 1);
            Refill r = new Refill("Blue", 10, n);
            Pen p = new Pen(2, "Cello", r);
            Console.WriteLine("Refill Brand : "+p.brand);
            Console.WriteLine("Refill Length : "+p.capLength);
            Console.WriteLine("Refill Colour : "+p.r.Inkcolour);
            Console.WriteLine("Refill Length : "+p.r.Length);
            Console.WriteLine("Refill Nib Material : " + p.r.N.Materialtype);
            Console.WriteLine("Refill Nib Width : " + p.r.N.Nibwidth);
        }
    }
    class Refill
    {
        String inkcolour;
        int length;
        Nib n;
        Refill()
        {

        }
        public Refill(string inkcolour, int length, Nib n)
        {
            this.Inkcolour = inkcolour;
            this.Length = length;
            this.N = n;
        }

        public string Inkcolour { get => inkcolour; set => inkcolour = value; }
        public int Length { get => length; set => length = value; }
        internal Nib N { get => n; set => n = value; }
    }
    class Nib
    {
        string materialtype;
        int nibwidth;
        Nib()
        {

        }
        public Nib(string materialtype, int nibwidth)
        {
            this.Materialtype = materialtype;
            this.Nibwidth = nibwidth;
        }

        public string Materialtype { get => materialtype; set => materialtype = value; }
        public int Nibwidth { get => nibwidth; set => nibwidth = value; }
    }
}

