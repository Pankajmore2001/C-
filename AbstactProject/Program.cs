using System;
namespace AbstactProject{
    abstract class AbsParent
    {
        public void add(int x,int y)
        {
            Console.WriteLine(x+y);
        }
        public void sub(int x,int y)
        {
            Console.WriteLine(x-y);
        }
        public abstract void Mul(int x,int y);
        public abstract void Div(int x, int y);
    }
    class AbsChild:AbsParent
    {
        public override void Mul(int x, int y)
        {
            Console.WriteLine(x*y);   
        }
        public override void Div(int x, int y)
        {
            Console.WriteLine(x/y);
        }
        static void Main()
        {
            AbsChild AC = new AbsChild();
            AC.add(5,5);
            AC.sub(5,5);
            AC.Mul(5,5);
            AC.Div(5,5);
        }
    }
}