using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Assignment24Sept
{
    class PrintFiveTime
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 10, 30, 68, 130 };

            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < a.Length; j++)
                {
                    Console.Write(a[j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
    class FrqOfWords
    {
        static bool IsPresent(int i, string nm, string[] s)
        {
            for (int j=0; j<i; j++)
            {
                if (s[j] == nm)
                {
                    return true;
                }
            }
            return false;
        }
        static void CountWord(string str)
        {
            string[] a = str.Split(' ');
            for (int i=0; i<a.Length; i++)
            {
                int count = 1;
                if (IsPresent(i, a[i], a) == false)
                {
                    for (int j=i+1; j<a.Length; j++)
                    {
                        if (a[i] == a[j])
                            count++;
                    }
                    Console.WriteLine($"{a[i]} frq is : "+count);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the quote");
            string q = Console.ReadLine();
            CountWord(q);
        }
    }
    class Employee
    {
        int id;
        string name;
        Dept d;

        public Employee(int id,string name,Dept d)
        {
            this.id = id;
            this.name = name;
            this.d = d;
        }
        public override string ToString()
        {
            return "Employee Id : " + id + "\nEmployee Name : " + name + "\nDepartment : " + d;
        }

    }
    class Dept
    {
        int deptid;
        string dname;

        public Dept(int deptid,string dname)
        {
            this.deptid = deptid;
            this.dname = dname;
        }
        public override string ToString()
        {
            return "Department Id : " + deptid + "\nDepartment Name : " + dname;
        }
    }
    class TestEmp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Department Id");
            int dep = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Department  Name");
            string dnm = Console.ReadLine();
            Dept d = new Dept(dep, dnm);
            Employee[] emp = new Employee[3];
            for(int i=0; i<emp.Length; i++)
            {
                Console.WriteLine("Enter The Employee Id");
                int empid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter The Employee Name");
                string empnm = Console.ReadLine();
                emp[i] = new Employee(empid, empnm, d);
            }
            foreach(Employee elements in emp)
            {
                Console.WriteLine(elements);
            }
        }
    }
    class FindNonRep
    {
        static void NonRep(string s)
        {
            for (int i=0; i<s.Length; i++)
            {
                int count = 0;
                for (int j=i+1; j<s.Length; j++)
                {
                    if (s[i] == s[j])
                        count++;
                }
                if (count == 0)
                {
                    Console.WriteLine(s[i]);
                    break;
                }  
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the quote");
            string q = Console.ReadLine();
            NonRep(q);
        }
    }
    /*class frqOfMobNo
    {
        static bool IsPresent(long mn,long num, long currentpos)
        {
           for(int i=0; i<currentpos; i++)
            {
                int r = (int)mn % 10;
                if (r == num)
                    return true;
                mn = mn / 10;
            }
            return false;
        }
        static void FindFrqOfMob(long mn)
        {
            long r;
            for (int i=0; i<10; i++)
            {
                r = mn % 10;
                if (IsPresent(mn, r, i) == false)
                {
                    int c = 1;
                    for (int j=i+1; j<10-1; j++)
                    {
                        int r1 = (int)mn % 10;
                        if (r1 == r)
                            c++;
                        mn = mn / 10;
                    }
                    Console.WriteLine($"frequency of {r} is : " + c);
                }
                mn = mn / 10;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Mobile Number");
            long mob = long.Parse(Console.ReadLine());
            FindFrqOfMob(mob);
        }
    }*/
    class CommonChar
    {
        static bool IsPresent(char ch, int pos, string nm)
        {
            for(int i=0; i<pos; i++)
            {
                if (nm[i] == nm[pos])
                    return true;
            }
            return false;
        }
        static void FindCommon(string w1, string w2)
        {
            for(int i=0; i<w1.Length; i++)
            {
                if (IsPresent(w1[i], i, w1)==false)
                {
                    for (int j = 0; j < w2.Length; j++)
                    {
                        if (w1[i] == w2[j])
                            Console.WriteLine($"Common alfabates : {w1[i]}");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Word");
            string w1 = Console.ReadLine();
            Console.WriteLine("Enter Second Word");
            string w2 = Console.ReadLine();
            FindCommon(w1, w2);
        }
    }
    class IncOrDec
    {
        static bool IsIncreasing=true, IsDecreasing=true;
        static void CheckNum(int num)
        {
            int r=num%10;
            while (num > 0)
            {
                int rr = num % 10;
                num = num / 10;
                if (rr < r)
                {
                    IsDecreasing = false;
                }
                else if (rr > r)
                {
                    IsIncreasing = false;
                }
                r = rr;
                
            }
            if(IsIncreasing)
                Console.WriteLine("This is increasing number");
            else if(IsDecreasing)
                Console.WriteLine("This is decreasing number");
            else
                Console.WriteLine("This is bouncy number");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            CheckNum(num);
        }
    }
    
    class frqOfMob
    {
        static void findfrq(long mob)
        {
            long r;
            int zeroc=0,onec=0,twoc=0,threec=0,fourc=0,fivec=0,sixc=0,sevenc=0,eigthc=0,ninec = 0;
            while (mob > 0)
            {
                r = mob % 10;
                switch (r)
                {
                    case 0: zeroc++;
                        break;
                    case 1: onec++;
                        break;
                    case 2: twoc++;
                        break;
                    case 3:  threec++;
                        break;
                    case 4: fourc++;
                        break;
                    case 5: fivec++;
                        break;
                    case 6: sixc++;
                        break;
                    case 7: sevenc++;
                        break;
                    case 8: eigthc++;
                        break;
                    case 9: ninec++;
                        break;
                        
                }
                mob = mob / 10;
            }
            Console.WriteLine($"frequency of 0 : {zeroc}\nfrequency of 1 : {onec}\nfrequency of 2 : {twoc}\nfrequency of 3 : {threec}\nfrequency of 4 : {fourc}\nfrequency of 5 : {fivec}\nfrequency of 6 : {sixc}\nfrequency of 7 : {sevenc}\nfrequency of 8 : {eigthc}\nfrequency of 9 : {ninec}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the mobile number");
            long mob = long.Parse(Console.ReadLine());
            findfrq(mob);
        }
    }
}
