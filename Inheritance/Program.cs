using System;
namespace Inheritance;
class Parent
{   
    public Parent()
    {
        Console.WriteLine("Parent class constructor is called.");
    }
    public void Test1()
    {
        Console.WriteLine("Method1");
    }
    public void Test2()
    {
        Console.WriteLine("Method2");
    }
}
class Child : Parent
{   
    public Child()
    {
        Console.WriteLine("Child class Constructor is called.");
    }
    public void Test3()
    {
        Console.WriteLine("Method3");
    }
    static void Main()
    {   
        Parent P; 
        Child b = new Child();
        P=b;    // P is reference variable of child class here
        Object obj = new object();
       
        P.Test1();
        P.Test2();
        b.Test3();
        
    }
}