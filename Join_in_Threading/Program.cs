using System;
using System.Threading;
namespace Join_in_Threading{
    public class Program{
        static void Test1()
        {
            Console.WriteLine("Thread1 is started.");
            for(int i =1;i<=25;i++)
            {
                Console.WriteLine("Test1: "+i);
            }
            Console.WriteLine("Thread1 is exiting.");
        }
        static void Test2()
        {
            Console.WriteLine("Thread2 is started.");
            for(int i =1;i<=25;i++)
            {
                Console.WriteLine("Test2: "+i);
            }
            Console.WriteLine("Thread2 is exiting.");
        }
        static void Test3()
        {
            Console.WriteLine("Thread3 is started.");
            for(int i =1;i<=25;i++)
            {
                Console.WriteLine("Test3: "+i);
            }
            Console.WriteLine("Thread3 is exiting.");
        }
        static void Main()
        {
            Console.WriteLine("Main Thread Started.");
            Thread T1 = new Thread(Test1);
            Thread T2 = new Thread(Test2);
            Thread T3 = new Thread(Test3);
            T1.Start();T2.Start();T3.Start();
            T1.Join();T2.Join();T3.Join();
            Console.WriteLine("Main Thread is Exiting.");
        }
    }
}