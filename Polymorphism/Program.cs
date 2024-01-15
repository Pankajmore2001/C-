using System;
namespace Polymorphism{
    public class Parent{
        public void Show()
        {
            Console.WriteLine("Parent class show method.");
        }
        public virtual void Test()  //can be override in child class
        {
            Console.WriteLine("Parent class Test Method");
        }
    }
    public class Child:Parent
    {
        public override void Test()     //Re-Implemnted a parent class method in child class
        {
            Console.WriteLine("Child class Test Method.");
        }
        static void Main(string[] args)
        {
        Child Obj = new Child();
        Obj.Show();
        Obj.Test();
        //Console.ReadLine();
        }
    }
}