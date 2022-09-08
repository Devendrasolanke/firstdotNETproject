using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Containments
{
       
    abstract class Teacher
    {
        int TeacherId;
        string TeacherName;
        long TeacherMobNo;

        protected Teacher(int teacherId, string teacherName, long teacherMobNo)
        {
            TeacherId = teacherId;
            TeacherName = teacherName;
            TeacherMobNo = teacherMobNo;
        }

        public int TeacherId1 { get => TeacherId; set => TeacherId = value; }
        public string TeacherName1 { get => TeacherName; set => TeacherName = value; }
        public long TeacherMobNo1 { get => TeacherMobNo; set => TeacherMobNo = value; }

        public abstract void salary();
    }
    class HourlyBased:Teacher
    {
        string RatePerHour;
        int Hours;

        public HourlyBased(string ratePerHour, int hours, int teacherId, string teacherName, long teacherMobNo):base(teacherId,teacherName,teacherMobNo)
        {
            RatePerHour1 = ratePerHour;
            Hours1 = hours;
        }

        public string RatePerHour1 { get => RatePerHour; set => RatePerHour = value; }
        public int Hours1 { get => Hours; set => Hours = value; }

        public override void salary()
        {
            Console.WriteLine("Rate per Hour : "+RatePerHour);
        }
    }
    class SalaryBased:Teacher
    {
        int Salary;

        public SalaryBased(int salary, int teacherId, string teacherName, long teacherMobNo):base( teacherId, teacherName, teacherMobNo)
        {
            Salary1 = salary;
        }

        public int Salary1 { get => Salary; set => Salary = value; }

        public override void salary()
        {
            Console.WriteLine("Monthly Salary : "+Salary1);
        }
    }
    class CheckTeacher
    {
        static void Main(string[] args)
        {
            HourlyBased Hobj = new HourlyBased("300 Rs/hr", 8, 112, "Deepa Shah", 9876543210);
            SalaryBased SalObj = new SalaryBased(45000, 123, "Kalyani A", 0987654321);
            Console.WriteLine("Teacher Name : "+Hobj.TeacherName1);
            Console.WriteLine("Teacher Id : "+Hobj.TeacherId1);
            Console.WriteLine($"Salary per month {SalObj.Salary1}");
            Console.WriteLine($"Rate per hour {Hobj.RatePerHour1}");
        }
    }
}
