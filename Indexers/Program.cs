using System;
using Indexers;
namespace Indexers
{
    public class Employee
    {
        int Eno;
        double Salary;
        string Ename,Job,Dname,Location;
        public Employee(int Eno,string Ename,string Job, double Salary, string Dname, string Location)
        {
            this.Eno = Eno;
            this.Ename = Ename;
            this.Job = Job;
            this.Salary = Salary;
            this.Dname = Dname;
            this.Location= Location;
        }

        //Indexers
        public object this[int index]
        {
            get
            {
                if(index == 0)
                    return Eno;
                else if(index == 1)
                    return Ename;
                else if(index == 2)
                    return Job;
                else if(index == 3)
                    return Salary;
                else if(index == 4)
                    return Dname;
                else if(index == 5)
                    return Location;
                return null;

            }
            set
            {   
                if(index == 0)
                    Eno=(int)value;
                else if(index == 1)
                    Ename = (string)value;
                else if(index == 2)
                    Job = (string)value;
                else if(index == 3)
                    Salary = (double)value;
                else if(index == 4)
                    Dname = (string)value;
                else if(index == 5)
                    Location = (string)value;
                
            }
        }
    }
    public class TestEmployee
    {
        static void Main(string[] args)
        {
            Employee Emp = new Employee(100,"Pankaj","Manager",25000,"IT","Mumbai");

            //using Indexer to get value
            Console.WriteLine("Eno: "+Emp[0]);
            Console.WriteLine("Ename: "+Emp[1]);
            Console.WriteLine("Job: "+Emp[2]);
            Console.WriteLine("Salary: "+Emp[3]);
            Console.WriteLine("Dname: "+Emp[4]);
            Console.WriteLine("Location: "+Emp[5]);

            //using indexers to modify values
            Emp[2]="Sr.Manager";
            Emp[3]=300000.00;
            Console.WriteLine();
            Console.WriteLine("Eno: "+Emp[0]);
            Console.WriteLine("Ename: "+Emp[1]);
            Console.WriteLine("Job: "+Emp[2]);
            Console.WriteLine("Salary: "+Emp[3]);
            Console.WriteLine("Dname: "+Emp[4]);
            Console.WriteLine("Location: "+Emp[5]);

        }
    }
}