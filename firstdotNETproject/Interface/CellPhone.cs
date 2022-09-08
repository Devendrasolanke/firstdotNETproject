using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Interface
{
    interface CellPhone
    {
        void Call();
        void PhoneBook();
        void Calculator();
    }
    class SmartPhone : CellPhone
    {
        public void Calculator()
        {
            Console.WriteLine("Simple Calculator");
        }

        public void Call()
        {
            Console.WriteLine("calling");
        }

        public void PhoneBook()
        {
            Console.WriteLine("Phonebook");
        }
        public void Music()
        {
            Console.WriteLine("Music");
        }
        public void VideoPlayer()
        {
            Console.WriteLine("Videoplayer");
        }
        public void VideoCall()
        {
            Console.WriteLine("VideoCalling");
        }
    }
    class TestCellPhone
    {
        static void Main(string[] args)
        {
            SmartPhone obj = new SmartPhone();
            Console.WriteLine("Specification in CellPhone");
            obj.Calculator();
            obj.Call();
            obj.PhoneBook();
            Console.WriteLine();
            Console.WriteLine("Specifications in SmartPhone afte upgrading CellPhone");
            obj.Calculator();
            obj.Call();
            obj.PhoneBook();
            obj.Music();
            obj.VideoPlayer();
            obj.VideoCall();
        }
    }
}
