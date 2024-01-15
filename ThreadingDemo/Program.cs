using System;
using System.Threading;
namespace ThreadingDemo{
    public class Program
    {
        static void test1()
        {
            for(int i = 1;i<=100;i++)
            {
                Console.WriteLine("Test1: "+ i);
            }
        }

        static void test2()
        {
            for(int i = 1;i<=100;i++)
            {
                if(i == 50)
                {
                    Console.WriteLine("Thread is Slpeeping");
                    Thread.Sleep(5000);
                    Console.WriteLine("Thread is awake");
                }
                Console.WriteLine("Test2: "+ i);
            }
        }
        static void test3()
        {
            for(int i = 1;i<=100;i++)
            {
                Console.WriteLine("Test3: "+ i);
            }
        }
        static void Main()
        {
            test1();
            test2();
            test3();
        }
}
}