using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.StringTopic
{
    class ValidEmail
    {
        static void CheckValidMail(string s)
        {
            if (s.Contains("@gmail.com"))
            {
                Console.WriteLine("valid Email id");
            }
            else
                Console.WriteLine("Not valid Email id");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Email id");
            string s = Console.ReadLine();
            CheckValidMail(s);
        }
    }
    class Allfunctions
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
            foreach (char ch in a)
                Console.Write(ch);
            Console.WriteLine();
            foreach (string s2 in sa)
                Console.WriteLine(s);
        }
    }
    class CharIndex
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Name");
            string s = Console.ReadLine();
            Console.WriteLine("Enter char to find first index");
            char ch = Convert.ToChar(Console.ReadLine());
            int s1 = s.IndexOf(ch);
            Console.WriteLine($"this is first occurence of {ch} is {s1}");
        }
    }
    class frqOfChar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Name");
            string s = Console.ReadLine();
            Console.WriteLine("Enter char to find frequency");
            char ch = Convert.ToChar(Console.ReadLine());
            int count = 0;
            foreach(char chh in s)
            {
                if (chh == ch)
                    count++;
            }
            Console.WriteLine($"frequency of {ch} is {count}");
        }
    }
    class RemoveSpaces
    {
        static void Main(string[] args)
        {
            string s = "  Devendra Solanke  ";
            int count = 0;
            foreach(char ch in s)
            {
                if (ch == ' ')
                {
                    count++;
                }
                else
                    break;
            }
            string s1 = s.Substring(count);
            Console.WriteLine(s1);
        }
    }
    class TotalChar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string s = Console.ReadLine();
            int count = 0;
            foreach(char ch in s)
            {
                if(ch!=' ')
                {
                    count++;
                }
            }
            Console.WriteLine($"char in string are : {count}");
        }
    }
    class TotalWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string s = Console.ReadLine();
            string[] sarr = s.Split();
            Console.WriteLine($"total words in string are {sarr.Length}");
        }
    }
    class IndexOfWord
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string s = Console.ReadLine();
            Console.WriteLine("Enter word to find index");
            string w = Console.ReadLine();
            string[] sarr = s.Split();
            for (int i = 0; i < sarr.Length; i++)
            {
                if (w == sarr[i])
                { 
                    Console.WriteLine($"first occurence of {w} is {i}");
                    break;
                }
            }
        }
    }
    class PelindromeWord
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Word");
            string s = Console.ReadLine();
            string w = "";
            for(int i=s.Length-1; i>=0; i--)
            {
                w = w + s[i];
            }
            if (s == w)
            {
                Console.WriteLine("pelindrome");
            }
            else
                Console.WriteLine("not pelindrome");
        }
    }
    class FrqOfWords
    {
        static bool IsPresent(string[] s, int currentpos)
        {
            for(int i=0; i<currentpos; i++)
            {
                if (s[currentpos] == s[i])
                    return true;
            }
            return false;
        }
        static void CheckFrqOfWords(string s)
        {
            string[] sarr = s.Split();
            for(int i=0; i<sarr.Length; i++)
            {
                int count = 1;
                if ((IsPresent(sarr, i)) == false)
                {
                    
                    for(int j=i+1; j<sarr.Length-1; j++)
                    {
                        if (sarr[i] == sarr[j])
                            count++;
                    }
                    
                }
                Console.WriteLine($"frequency of {sarr[i]} is {count}");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string s = Console.ReadLine();
            CheckFrqOfWords(s);
        }
    }
    class LongestWord
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string s = Console.ReadLine();
            string[] sarr = s.Split();
            string n = "";
            int count = 0;
            foreach(string wrd in sarr)
            {
                if (wrd.Length > count)
                {
                    n = wrd;
                    count = wrd.Length;
                }
            }
            Console.WriteLine($"longest word in string is : {n}");
        }
    }
    class UniqAlfabates
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string s = Console.ReadLine();
            string sn = "";
            foreach (char ch in s)
            {
                if (sn.Contains(ch) == false)
                    sn = sn + ch;
            }
            Console.WriteLine($"Unique alfabates in string are {sn}");
        }
    }
    class ValidName
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            string s = Console.ReadLine();
            bool flag = true;
            foreach (char ch in s)
            {
                if (char.IsLetter(ch) == false)
                {
                    flag = false;
                    break;
                }
            }
            if(flag==true)
                Console.WriteLine("valid name");
            else
                Console.WriteLine("invalid name");
        }
    }
    class ReverseWord
    {
        static string PrintRev(string s)
        {
            string ss = "";
            for (int i=s.Length-1; i>=0; i--)
            {
                ss = ss + s[i];
            }
            return ss;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string s = Console.ReadLine();
            string sss="";
            string[] sarr = s.Split();
            foreach(string ss in sarr)
            {
                sss = PrintRev(ss);
                Console.Write(sss+" ");
            }
        }
    }
    class SumOfStringDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            int sum = 0;
            foreach(char ch in s)
            {
                if (char.IsDigit(ch))
                {
                    sum = sum + (ch-48);
                }
            }
            Console.WriteLine(sum);
        }
    }
}
