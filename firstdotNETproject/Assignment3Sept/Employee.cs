using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Assignment3Sept
{
    class Employee
    {
        int EmployeeId;
        string EmployeeName;
        Dept d;
        public Employee()
        {

        }
        public Employee(int employeeId, string employeeName, Dept d)
        {
            EmployeeId1 = employeeId;
            EmployeeName1 = employeeName;
            this.D = d;
        }

        public int EmployeeId1 { get => EmployeeId; set => EmployeeId = value; }
        public string EmployeeName1 { get => EmployeeName; set => EmployeeName = value; }
        internal Dept D { get => d; set => d = value; }
    }
    class Dept
    {
        int DeptId;
        string DeptName;
        public Dept()
        {

        }
        public Dept(int deptId, string deptName)
        {
            DeptId1 = deptId;
            DeptName1 = deptName;
        }

        public int DeptId1 { get => DeptId; set => DeptId = value; }
        public string DeptName1 { get => DeptName; set => DeptName = value; }
    }
    class CheckEmployee
    {
        static void Main(string[] args)
        {
            Dept DepObj = new Dept(123, "Department Of Developing");
            Employee EmpObj = new Employee(321, "Devendra Solanke", DepObj);
            Console.WriteLine("Employee Name : "+EmpObj.EmployeeName1);
            Console.WriteLine("Employee Code : "+EmpObj.EmployeeId1);
            Console.WriteLine("Department : "+EmpObj.D.DeptName1);
        }
    }
}
