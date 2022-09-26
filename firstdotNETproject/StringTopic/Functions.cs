using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.StringTopic
{
    class Functions
    {
        static void Main(string[] args)
        {
            /*string s = "  Devendra Solanke  ";
            int idx = s.IndexOf('v');
            int lastidx = s.LastIndexOf('e');
            string t = s.Trim();
            string ss = s.Substring(2);
            string sss = s.Substring(2, 3);
            Console.WriteLine(idx);
            Console.WriteLine(lastidx);
            Console.WriteLine(t);
            Console.WriteLine(ss);
            Console.WriteLine(sss);*/
            Console.WriteLine("Enter the name");
            string nm = Console.ReadLine();
            int i = 1;
            string n = nm.Substring(0, i) + nm.Substring(i + 1);
            Console.WriteLine(n);
        }
    }
}
