using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.StringTopic
{
    class CompairString
    {
        static void Main(string[] args)
        {
            string s1 = "string";
            string s2 = "string";
            string s3 = new string("string");
            string s4 = new string("string");

            Console.WriteLine(Object.ReferenceEquals(s1,s2));//Address comp
            Console.WriteLine(Object.ReferenceEquals(s3,s4));//Address comp
            Console.WriteLine(s1==s2);//data comp
            Console.WriteLine(s3==s4);//data comp
        }
    }
    class StringPelindrome
    {
        static void checkPelindrome(string s)
        {
            string rev = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                rev = rev + s[i];
            }
            if (rev == s)
                Console.WriteLine("Pelindrome");
            else
                Console.WriteLine("Not Pelindrome");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name");
            string s = Console.ReadLine();
            checkPelindrome(s);
        }
    }
    class StringAssign
    {
        static void frqOfChar()
        {
            Console.WriteLine("Enter the name");
            string s = Console.ReadLine();
            Console.WriteLine("Enter the char for calculating frq");
            char ch = Convert.ToChar(Console.ReadLine());
            int c = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ch)
                    c++;
            }
            Console.WriteLine("The frq is : "+c);
        }
        static void toggle(string s)
        {
            string charrr = "";
            for (int i=0; i<s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                {
                    charrr =charrr + char.ToLower(s[i]);
                }
                else
                {
                    charrr = charrr + char.ToUpper(s[i]);
                }
            }
            Console.WriteLine(charrr);
        }
        static void findwovel(string s)
        {
            int c = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
               if(s[i]=='a'|| s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                {
                    c++;
                }
            }
            Console.WriteLine($"wovel in {s} is : "+c);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name");
            string s = Console.ReadLine();
            findwovel(s);
            toggle(s);
            frqOfChar();
        }
    }
}
