using System;
namespace MultipleInheritance{
    interface interface1
    {
        void Test();
        void show();
    }
    interface interface2
    {
        void Test();
        void show();
    }
    public class Implement:interface1,interface2
    {
        public void Test()                  //method 1
        {
            Console.WriteLine("Child class Implements Interfaces Methods.");
        }
        void interface1.show()              //Method 2
        {
            Console.WriteLine("Child class Implements interface1 show method.");
        }
        void interface2.show()
        {
            Console.WriteLine("Child class Implements interface2 show method.");
        }
        static void Main()
        {
            Implement I = new Implement();
            interface1 obj = I;
            interface2 obj2 = I;

            I.Test();
            obj.show();
            obj2.show();
        }
    }
}