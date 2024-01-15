using System;
using System.Collections;
namespace HashtableExample{
    class Program
    {
        public static void Main(string[] agrs)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Eid",100);
            ht.Add("Ename","Pankaj");
            ht.Add("Job","Software Developer");
            ht.Add("Salary",25000);
            ht.Add("Mgrid",1000);
            ht.Add("Phone","9405537494");
            ht.Add("Email","morep9876@gmail.com");
            ht.Add("Dname","IT");
            ht.Add("Location","Pune");
            ht.Add("Did",30);

            foreach(object key in ht.Keys)
            {
                Console.WriteLine(key+":"+ht[key]);
            }
            Console.ReadLine();
        }
    }
}