using System;
namespace MethodHiding{
    public class Parent{
        public virtual void Test1()
        {
            Console.WriteLine("Parent class Test1 Method.");
        }
        public void Test2()
        {
            Console.WriteLine("Parent class Test2 Method.");
        }
    }
    public class Child:Parent{
        public void ParentTest1()
        {
            base.Test1();
        }
        public void ParentTest2()
        {
            base.Test2();
        }
        public override void Test1()        // method overriding
        {
            Console.WriteLine("Child class Test1 Method.");
        }
        public new void Test2()             // method hiding/Shadowing
        {
            Console.WriteLine("Child class Test2 Method.");
        }
        public static void Main(String[] args)
        {
            Child c = new Child();
            c.ParentTest1();
            c.ParentTest2();
            c.Test1();
            c.Test2();
        }
    }
}