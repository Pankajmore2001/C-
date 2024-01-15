using System;
using System.Collections.Generic;
namespace ListExample{
    public class Program{
        static void Main(string [] args)
        {
            List<int> li = new List<int>();
            li.Add(10);
            li.Add(20);
            li.Add(30);
            li.Add(40);
            li.Add(50);

            for(int i =0; i<li.Count;i++)
            {
                Console.Write(li[i]+" ");
            }
            Console.WriteLine();
            li.Insert(3,35);        //Inserting an item at location 3 

            foreach(int v in li)
            {
                Console.Write(v+" ");
            }
            Console.WriteLine();

            li.Remove(35);          //removing an item 35
            foreach(int v in li)
            {
                Console.Write(v+" ");
            }
            Console.WriteLine();

            li.RemoveAt(3);         //removing item at location 3 
            foreach(int v in li)
            {
                Console.Write(v+" ");
            }
            Console.WriteLine();
        }

    }
}