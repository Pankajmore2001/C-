using System;
using System.Runtime.CompilerServices;
namespace Practice
{
public class shape
    {
        public virtual void Display()
        {
            Console.WriteLine("This is shape");
        }
        
    }
public class Circle: shape
    {
        public override void Display()
        {
            Console.WriteLine("This is Circle");
        }
    }
    public class Program
    {
        static void Main()
        {
       Circle C = new Circle();
       C.Display();

        }
       

    }
}