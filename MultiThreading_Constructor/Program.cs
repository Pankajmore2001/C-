using System;
using System.Threading;
namespace MultiThreading_Constructor{
    public class Program{
        static void Test1()
        {
            for(int i = 1;i<=100;i++)
            {
                Console.WriteLine("Test : "+i);
            }
        }
        static void Test2(object Max)
        {
            int num = Convert.ToInt32(Max);
            for(int i = 1;i<=num;i++)
            {
                Console.WriteLine("Test2 : "+ i);
            }
        }
        static void Main()
        {
            //Method 1
            //Thread T = new Thread(Test1);
            //T.Start();

            //Methood 2
            // ThreadStart obj = new ThreadStart(Test1);
            // Thread T = new Thread(obj);
            //T.Start();

            //Method 3
            // ThreadStart obj = Test1;
            // Thread T = new Thread(obj);
            // T.Start();

            //Method 4(using ananamous Method)
            // ThreadStart obj = delegate(){Test1();};
            // Thread T = new Thread(obj);
            // T.Start();

            //Method 5(using lambda function)
            // ThreadStart obj = () => Test1();
            // Thread T = new Thread(obj);
            // T.Start();

            //Parameterized Delegate
            ParameterizedThreadStart obj = new ParameterizedThreadStart(Test2);
            Thread T = new Thread(obj);
            T.Start(hello);
        }
    }
}