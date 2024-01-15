using System;
using System.Collections.Generic;
namespace GenericList_Example{
    public class Customer{
        public int Custid{get; set;}
        public string Name{get;set;}
        public string City{get;set;}
        public int Balance{get;set;}
    }
    public class TestClass{
        static void Main()
        {
            List<Customer> Customers = new List<Customer>();
            Customer c1 = new Customer{Custid = 101, Name = "Pankaj" , City = "Pune", Balance = 25000};
            Customer c2 = new Customer{Custid = 102, Name = "Suraj" , City = "Nashik", Balance = 29000};
            Customer c3 = new Customer{Custid = 103, Name = "Gaurav" , City = "Mumbai", Balance = 30000};
            Customer c4 = new Customer{Custid = 104, Name = "Vidya" , City = "Dhule", Balance = 50000};

            Customers.Add(c1);Customers.Add(c2);
            Customers.Add(c3);Customers.Add(c4);
            foreach(Customer obj in Customers)
            {
                Console.WriteLine(obj.Custid + "\t"+ obj.Name + "\t"+ obj.City+ "\t"+ obj.Balance);
            }

        }
    }
}