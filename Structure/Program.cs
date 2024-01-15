using System;
namespace Structure{
    struct Mystruct
    {
        int i;
        public Mystruct(int i)
        {
            this.i=i;
        }
        public void Display()
        {
            Console.WriteLine("Display Method inside Structure with Value of i "+ i);
        }
    static void Main()
    {
        Mystruct M ;
        M.i=10;
        M.Display();
        Mystruct M2 = new Mystruct();   //parameterless constructure
        M2.Display();
        Mystruct M3 = new Mystruct(30); //parametirised constructure
        M3.Display();

    }
    }
}