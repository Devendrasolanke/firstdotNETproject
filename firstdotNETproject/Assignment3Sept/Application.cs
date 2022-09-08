using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Assignment3Sept
{
    class Application
    {
        string Version;
        string Technology;
        Developer d;
        public Application()
        {

        }
        public Application(string version, string technology, Developer d)
        {
            Version1 = version;
            Technology1 = technology;
            this.D = d;
        }

        public string Version1 { get => Version; set => Version = value; }
        public string Technology1 { get => Technology; set => Technology = value; }
        internal Developer D { get => d; set => d = value; }

        public void install()
        {
            Console.WriteLine("Application Installing..........");
        }
        public void uninstall()
        {
            Console.WriteLine("Application Uninstalling..........");
        }
    }
    class Developer
    {
        string devName;
        int devExperience;
        string Skill;
        public Developer()
        {

        }
        public Developer(string devName, int devExperience, string skill)
        {
            this.DevName = devName;
            this.DevExperience = devExperience;
            Skill1 = skill;
        }

        public string DevName { get => devName; set => devName = value; }
        public int DevExperience { get => devExperience; set => devExperience = value; }
        public string Skill1 { get => Skill; set => Skill = value; }

        void debug()
        {
            Console.WriteLine("Started Debugging.........");
        }
        void integratedCode()
        {
            Console.WriteLine("Started Integrated Coding........");
        }
    }
    class DesktopApplication
    {
        string software;
        Application a;
        public DesktopApplication()
        {

        }
        public DesktopApplication(string software, Application a)
        {
            this.Software = software;
            this.A = a;
        }

        public string Software { get => software; set => software = value; }
        internal Application A { get => a; set => a = value; }
    }
    class WebApplication
    {
        string Software;
        Application A;
        public WebApplication()
        {

        }
        public WebApplication(string software, Application a)
        {
            Software1 = software;
            A1 = a;
        }

        public string Software1 { get => Software; set => Software = value; }
        internal Application A1 { get => A; set => A = value; }
    }
    class AppTest
    {
        static void Main(string[] args)
        {
            Developer DevObj = new Developer("Devendra Solanke", 5, "C# .NET Developer");
            Application AppObj = new Application("Version 3.O", "C# Technology", DevObj);
            DesktopApplication Desk = new DesktopApplication("Desktop Software", AppObj);
            WebApplication WebObj = new WebApplication("Web Software", AppObj);
            Console.WriteLine("Developer Name : "+AppObj.D.DevName);
            Console.WriteLine("Developer Skill : "+AppObj.D.Skill1);
            Console.WriteLine("Software Technology : "+AppObj.Technology1);
            Console.WriteLine("Software Version : "+AppObj.Version1);
            AppObj.install();
        }
    }
}
