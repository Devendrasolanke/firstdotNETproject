using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Containments
{
    class Order
    {
        int OrderId;
        string OrderDate;
        Customer C;
        Item I;
        Order()
        {

        }
        public Order(int orderId, string orderDate, Customer c, Item i)
        {
            OrderId = orderId;
            OrderDate = orderDate;
            C = c;
            I = i;
        }
        static void Main(string[] args)
        {
            Address a1 = new Address("Nandurbar, Tal. Dist. Nandurbar", 425412);
            Item i1 = new Item(321, "Pizza", 199);
            Customer c1 = new Customer(1234, "Devendra Solanke", a1);
            Order o1 = new Order(111, "31 Aug 2022", c1, i1);
            Console.WriteLine("Customer Name : "+o1.C.CustomerName);
            Console.WriteLine("Customer Id : "+o1.C.CustomerId);
            Console.WriteLine("Customer Address : "+o1.C.A1.Addresss);
            Console.WriteLine("Customer Pincode : "+o1.C.A1.Pincode);
            Console.WriteLine("Customer Order Id : "+o1.OrderId);
            Console.WriteLine("Customer Order Date : "+o1.OrderDate);
            Console.WriteLine("Customer Itom Id : "+o1.I.ItomId);
            Console.WriteLine("Customer Itom Name : "+o1.I.Itomname);
            Console.WriteLine("Customer Itom Price : "+o1.I.Itomprice);
        }
    }
    class Customer
    {
        int customerId;
        string customerName;
        Address A;
        Customer()
        {

        }
        public Customer(int customerId, string customerName, Address a)
        {
            this.CustomerId = customerId;
            this.CustomerName = customerName;
            A1 = a;
        }

        public int CustomerId { get => customerId; set => customerId = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        internal Address A1 { get => A; set => A = value; }
    }
    class Address
    {
        string address;
        int pincode;
        Address()
        {

        }
        public Address(string address, int pincode)
        {
            this.address = address;
            this.Pincode = pincode;
        }

        public string Addresss { get => address; set => address = value; }
        public int Pincode { get => pincode; set => pincode = value; }
    }
    class Item
    {
        int itomId;
        string itomname;
        int itomprice;
        Item()
        {

        }
        public Item(int itomId, string itomname, int itomprice)
        {
            this.ItomId = itomId;
            this.Itomname = itomname;
            this.Itomprice = itomprice;
        }

        public int ItomId { get => itomId; set => itomId = value; }
        public string Itomname { get => itomname; set => itomname = value; }
        public int Itomprice { get => itomprice; set => itomprice = value; }
    }
   
}
