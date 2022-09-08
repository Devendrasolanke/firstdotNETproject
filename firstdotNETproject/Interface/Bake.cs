using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Interface
{
    interface Cake
    {
        void Bake();
    }
    class Strawberry : Cake
    {
        public void Bake()
        {
            Console.WriteLine("Strawberry Cake is Baking........");
        }
    }
    class Blackforest : Cake
    {
        public void Bake()
        {
            Console.WriteLine("Blackforest Cake is Baking......");
        }
    }
    class TestCake
    {
        static void Main(string[] args)
        {
            Strawberry s = new Strawberry();
            Blackforest b = new Blackforest();
            s.Bake();
            b.Bake();
        }
        
    }
}
