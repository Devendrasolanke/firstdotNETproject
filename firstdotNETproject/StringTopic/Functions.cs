using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.StringTopic
{
    class Functions
    {
        static void Main(string[] args)
        {
            string s = "  Devendra Solanke  ";
            int idx = s.IndexOf('v');
            int lastidx = s.LastIndexOf('e');
            string t = s.Trim();
            string ss = s.Substring(2);
            string sss = s.Substring(2, 3);
            Console.WriteLine(idx);
            Console.WriteLine(lastidx);
            Console.WriteLine(t);
            Console.WriteLine(ss);
            Console.WriteLine(sss);

            string s1 = "Devendra";
            s1 = s1.Replace('e', 'a');
            Console.WriteLine(s1);

            Console.WriteLine("Enter the name");
            string nm = Console.ReadLine();
            int i = 1;
            string n = nm.Substring(0, i) + nm.Substring(i + 1);
            Console.WriteLine(n);
            char[] a = nm.ToCharArray();
            string[] sa = nm.Split();
            foreach(char ch in a)
                Console.Write(ch);
            Console.WriteLine();
            foreach(string s2 in sa)
                Console.WriteLine(s);

        }
    }
    class Xyz
    {
        static void Main(string[] args)
        {
            string s = "Devendra";
            string a = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != 'e')
                {
                    a = a + s[i];
                }
                Console.WriteLine(a);
            }
        }
    }
}
