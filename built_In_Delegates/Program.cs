using System;
namespace built_In_Delegates{
    public class Program{
        public static int Additon(int a,int b, int c)
        {
            return a+b+c;
        }
        public static void Addition2(int a,int b, int c)
        {
            Console.WriteLine("Addition of 3 numbers is : "+(a+b+c));
        }
        public static bool Checklen(string str)
        {
            if(str.Length<5)
                return true;
            return false;
        }
        static void Main()
        {
            //In-Built delegates
            //1) Func
            Func<int,int,int,int> valaue = Additon;
            Console.WriteLine("Addition of 3 numbers is : "+valaue(1,1,1));

            //2) Action
            Action<int,int,int> value1 = Addition2;
            value1(1,1,1);
            
            //3) Predicate
            Predicate<string> val = Checklen;
            Console.WriteLine(val("hello"));
        }
    }
}