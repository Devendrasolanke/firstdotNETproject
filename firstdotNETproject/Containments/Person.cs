using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Containments
{
    class Person
    {
        int id;
        string name;
        vehicle v;

        public Person(int id, string name, vehicle v)
        {
            this.id = id;
            this.name = name;
            this.v = v;
        }
        static void Main(string[] args)
        {
            vehicle v1 = new vehicle(1234, "xcent");
            Person p1 = new Person(123, "Devendra Solanke", v1);
            Console.WriteLine("Person Name : "+p1.name);
            Console.WriteLine("Person Id : "+p1.id);
            Console.WriteLine("Vehicle Name : "+v1.Vehicle_name1);
            Console.WriteLine("Vehicle Id : "+v1.Vehicle_Id1);
        }
    }
    class vehicle
    {
        int Vehicle_Id;
        string Vehicle_name;

        public vehicle(int vehicle_Id, string vehicle_name)
        {
            Vehicle_Id1 = vehicle_Id;
            Vehicle_name1 = vehicle_name;
        }

        public int Vehicle_Id1 { get => Vehicle_Id; set => Vehicle_Id = value; }
        public string Vehicle_name1 { get => Vehicle_name; set => Vehicle_name = value; }
    }
}
