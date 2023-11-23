using System;
namespace Constructors
{
    class ParameterizedConDemo
    {
        public ParameterizedConDemo(int i)
        {
            Console.WriteLine("The Parameterized Constructor is called and value of i is "+ i);
            
        }
        static void Main()
        {
            ParameterizedConDemo obj = new ParameterizedConDemo(10);

        }
    }
   
}