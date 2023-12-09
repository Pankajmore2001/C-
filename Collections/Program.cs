using System;
using System.Collections.Generic;
namespace Collections
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            for(int i =1;i<=10;i++)
            {
                myList.Add(5*i);
            }
            Console.WriteLine("Items :");
            foreach(int items in myList)
            {
                Console.Write(items+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Capacity of List:"+ myList.Capacity);
        }
    }
}