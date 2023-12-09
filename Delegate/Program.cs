using System;
namespace Delegate{

    //Step 1 : Declare delegate
    public delegate void AddDelegate(int x, int y);
    public delegate void PrintDelegate(string s);

    public class TestDelegate
    {
        public void Add(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        public void print(string str)
        {
            Console.WriteLine("Hello "+str);
        }
        static void Main(String[] args)
        {
            TestDelegate T =  new TestDelegate();
            //Step 2 : Instatiate Delegate
            AddDelegate Ad = new AddDelegate(T.Add);
            //Step 3 : Call methods using delegate
            Ad(100,300);

            PrintDelegate Pt = new PrintDelegate(T.print);
            Pt.Invoke("Pankaj");

        }
    }
}