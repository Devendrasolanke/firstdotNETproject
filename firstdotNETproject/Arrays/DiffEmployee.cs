using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Arrays
{
    class DiffEmployee
    {
        string EmpName;
        int EmpId;
        string Branch;

        public DiffEmployee(string EmpName, int EmpId, string Branch)
        {
            this.EmpName = EmpName;
            this.EmpId = EmpId;
            this.Branch = Branch;
        }
        public override string ToString()
        {
            return "Employee Name : "+EmpName+"\nEmployee Id :  "+EmpId+"\nEmployee Branch : "+Branch;
        }
    }
    class TestEmployee
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size");
            int size = int.Parse(Console.ReadLine());
            DiffEmployee[] Emp = new DiffEmployee[size];
            for(int i=0; i<size; i++)
            {
                Console.WriteLine("Enter Employee Name, Employee Id,  Branch");
                string EmpName = Console.ReadLine();
                int EmpId = int.Parse(Console.ReadLine());
                string Branch = Console.ReadLine();
                Emp[i] = new DiffEmployee(EmpName, EmpId, Branch);
            }

            foreach(DiffEmployee element in Emp)
                Console.WriteLine(element);
        }
    }

}