using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Containments
{
    class Student
    {
        string studname;
        int passoutyear;
        Batch b;
        Student()
        {

        }
        public Student(string studname, int passoutyear, Batch b)
        {
            this.Studname = studname;
            this.Passoutyear = passoutyear;
            this.B = b;
        }

        public string Studname { get => studname; set => studname = value; }
        public int Passoutyear { get => passoutyear; set => passoutyear = value; }
        internal Batch B { get => b; set => b = value; }
    }
    class Batch
    {
        string batchname;
        string technology;
        Trainer t;
        Batch()
        {

        }
        public Batch(string batchname, string technology, Trainer t)
        {
            this.Batchname = batchname;
            this.Technology = technology;
            this.T = t;
        }

        public string Batchname { get => batchname; set => batchname = value; }
        public string Technology { get => technology; set => technology = value; }
        internal Trainer T { get => t; set => t = value; }
    }
    class Trainer
    {
        string trainername;
        string qualification;
        int experience;
        Trainer()
        {

        }
        public Trainer(string trainername, string qualification, int experience)
        {
            this.Trainername = trainername;
            this.Qualification = qualification;
            this.Experience = experience;
        }

        public string Trainername { get => trainername; set => trainername = value; }
        public string Qualification { get => qualification; set => qualification = value; }
        public int Experience { get => experience; set => experience = value; }

        static void Main(string[] args)
        {
            Trainer t1 = new Trainer("Deepa Mam", "B.E.", 10);
            Batch b1 = new Batch("Wipro", "C#", t1);
            Student s1 = new Student("Devendra Solanke", 2020, b1);
            Console.WriteLine("Student Name : "+s1.Studname);
            Console.WriteLine("Student Pass Out Year : "+s1.Passoutyear);
            Console.WriteLine("Student Batch : " +s1.B.Batchname);
            Console.WriteLine("Technology : "+s1.B.Technology);
            Console.WriteLine("Trainer Name : "+s1.B.T.trainername);
            Console.WriteLine("Qualification :"+s1.B.T.qualification);
            Console.WriteLine("Experience : "+s1.B.T.Experience+" Years");

        }
    }
}
