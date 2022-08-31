using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Containments
{
    class Teacher
    {
        int TeacherId;
        string TeacherName;
        long TeacherMob;

        public Teacher(int teacherId, string teacherName, long teacherMob)
        {
            TeacherId1 = teacherId;
            TeacherName1 = teacherName;
            TeacherMob1 = teacherMob;
        }

        public int TeacherId1 { get => TeacherId; set => TeacherId = value; }
        public string TeacherName1 { get => TeacherName; set => TeacherName = value; }
        public long TeacherMob1 { get => TeacherMob; set => TeacherMob = value; }

        

        static void Main(string[] args)
        {
            Teacher t1 = new Teacher(1234, "Deepa Mam", 9087654321);
            HourlyBased h1 = new HourlyBased("Rs.200/Hr", 8);
            SalaryBased s1 = new SalaryBased(50000);
            Console.WriteLine("Teacher Name : "+t1.TeacherName1);
            Console.WriteLine("Teacher Id : "+t1.TeacherId1);
            Console.WriteLine("Teacher Mob : "+t1.TeacherMob1);
            Console.WriteLine("Hourly Based Salery : "+h1.RatePerHour1);
            Console.WriteLine("Salery Based : "+s1.Salary1+" Rs.");
        }
    }
    class HourlyBased
    {
        string RatePerHour;
        int Hours;

        public HourlyBased(string ratePerHour, int hours)
        {
            RatePerHour1 = ratePerHour;
            Hours1 = hours;
        }

        public string RatePerHour1 { get => RatePerHour; set => RatePerHour = value; }
        public int Hours1 { get => Hours; set => Hours = value; }

        void salary()
        {
            Console.WriteLine("Rs/Hr : "+Hours1);
        }
    }
    class SalaryBased
    {
        int salary;

        public SalaryBased(int salary)
        {
            this.Salary1 = salary;
        }

        public int Salary1 { get => salary; set => salary = value; }

        void Salary()
        {
            Console.WriteLine("Monthly Salary : "+Salary1);
        }

    }
}
