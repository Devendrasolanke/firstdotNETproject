using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.StringTopic
{
    class Anagram
    {
        static void ToCheckAnagram(string w1,string w2)
        {
            if (w1.Length == w2.Length)
            {
                foreach(char ch in w1)
                {
                    int idx = w2.IndexOf(ch);
                    if (idx != -1)
                    {
                        w2 = w2.Substring(0, idx) + w2.Substring(idx + 1);
                        Console.WriteLine(w2);
                    }
                }
            }
            else
                Console.WriteLine("not anagram");
            if (w2.Length == 0)
                Console.WriteLine("anagram");
            else
                Console.WriteLine("not anagram");
        }
        static bool CheckIsPresent(string s, int currentpos, char ch)
        {
            for (int i=0; i<currentpos; i++)
            {
                if (ch == s[i])
                    return true;
            }
            return false;
        }
        static int ToCheck(string w1, string w2)
        {
            int count = 0;
            if (w1.Length == w2.Length)
            {
                for (int i = 0; i < w1.Length; i++)
                {
                    if (CheckIsPresent(w1, i, w1[i]) == false)
                    {
                        for (int j = 0; j < w2.Length; j++)
                                  {
                            if (w1[i] == w2[j])
                                count++;
                            
                        }
                        
                    }
                }
                return count; 
            }
            
                return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st word");
            string w1 = Console.ReadLine();
            Console.WriteLine("Enter the 2nd word");
            string w2 = Console.ReadLine();
            ToCheckAnagram(w1, w2);
            
        }
    }
}
