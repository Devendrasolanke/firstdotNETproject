using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.OopsConcepts
{
    class Const
    {
        string title;
        string aname;
        double price;
        public Const(string title, string aname, double price)
        {
            this.Title = title;
            this.Aname = aname;
            this.Price = price;
        }

        public string Title { get => title; set => title = value; }
        public string Aname { get => aname; set => aname = value; }
        public double Price { get => price; set => price = value; }

        static void Main(string[] args)
        {
            Const c1 = new Const("Rich Dad Poor Dad","Robert T",350);
            Console.WriteLine("Title Name : "+c1.Title);
            Console.WriteLine("Auther Name : "+c1.Aname);
            Console.WriteLine("Book Price : "+c1.Price);
        }
    }
}
