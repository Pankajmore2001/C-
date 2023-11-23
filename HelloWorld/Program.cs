using System;
namespace HelloWorld
{
    class Program
    {
        int i;
        bool b;
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("The value of i: "+ p.i);
            Console.WriteLine("The Value of b: "+ p.b);
            Console.ReadLine();
        }
    }
    
}