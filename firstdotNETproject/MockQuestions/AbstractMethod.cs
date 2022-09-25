using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.MockQuestions
{
    abstract class A
    {
        string name;
        int age;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Age
        {
            set { age = value; }
            get { return age; }
        }

        void m1()
        {

        }

        public A(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

    }
    class B : A
    {
        long mobno;
        public long Mobno
        {
            set { mobno = value; }
            get { return mobno; }
        }
        public void m1()
        {
            Console.WriteLine("in child");
        }
        public B(string name, int age, long mobno) : base(name, age)
        {
            this.mobno = mobno;
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            B b1 = new B("devendra", 25, 987654321);
            b1.m1();
            Console.WriteLine(b1.Name);
            Console.WriteLine(b1.Age);
            Console.WriteLine(b1.Mobno);
        }
    }
}

