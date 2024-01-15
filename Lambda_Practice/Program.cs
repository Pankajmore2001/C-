using System;
using System.Collections.Generic;
using System.Linq;
namespace Lambda_Practice{
    public class Program
    {
        static void Main(string[] args)
        {
        List<int> numbers = new List<int>(){9,10, 12, 15, 16, 18};
        Console.WriteLine("The List:");
        foreach(var value in numbers)
        {
            Console.Write(value+" ");
        }
        Console.WriteLine();
        var Square = numbers.Select(x=>x*x);
        Console.WriteLine("The Square List:");
        foreach(var value in Square)
        {
            Console.Write(value+" ");
        }
        List<int> Divby3 = numbers.FindAll(x=>(x%3)==0);
        Console.WriteLine();
        Console.WriteLine("The numbers Divide by 3:");
        foreach(var v in Divby3)
        {
            Console.Write(v+" ");
        }
        }
    }
}