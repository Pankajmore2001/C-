using System;
namespace Interface{
    interface ITestinterface1
    {
        void add(int x,int y);
    }
    interface ITestinterface2 : ITestinterface1
    {
        void sub(int x,int y);
    }
    public class TestImplementation:ITestinterface2
    {
        public void add(int x,int y)
        {
            Console.WriteLine(x+y);
        }
        public void sub(int x,int y)
        {
            Console.WriteLine(x-y);
        }
         static void Main()
        {
        TestImplementation T = new TestImplementation();
        T.add(20,45);
        T.sub(67,66);
        Console.ReadLine();
        }
        
    }

}