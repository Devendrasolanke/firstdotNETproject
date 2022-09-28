using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.StringBuilderTopic
{
    class StringBuilderFunctions
    {
        static void Main(string[] args)
        {
            //create string builder
            StringBuilder sb = new StringBuilder("Mr. Devendra Dnyaneshwar Solanke");
            Console.WriteLine(sb);
            sb.Append(" From Nandurbar");//added this string in end of sb stringbuilder
            Console.WriteLine(sb);
            sb.AppendLine();// we use as writeline
            int length = sb.Capacity;//to find length of stringbuilder array
            Console.WriteLine(length);
            sb.Insert(12, "(Deva)");//insert data from 9th index and add Deva string
            Console.WriteLine(sb);
            sb.Remove(12, 6);//remove data from 9th index to 6 char
            Console.WriteLine(sb);
            sb.Replace('M', 'D');//replaced M to m
            Console.WriteLine(sb);
            string s = sb.ToString();//stringbuilder convert into string
            Console.WriteLine(s);
        }
    }
}
