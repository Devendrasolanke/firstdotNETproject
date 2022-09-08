using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Inheritance
{
    class Bank
    {
        string bankname;
        string bankbranch;
        string address;
        string ifsccode;

        public void Accept()
        {
            Console.WriteLine("in accept...");
        }
    }
    class SBI : Bank
    {
        float ROI=7.0f;
        
    }
    class Test
    {
        static void Main(string[] args)
        {
            SBI s = new SBI();
            s.Accept();
        }
    }
}
