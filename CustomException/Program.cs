using System;
namespace CustomException{
    public class DivideByOddNoException: Exception
    {
        override public string Message
        {
            get
            {
                return "Attempted to divide by Odd number.";
            }
        }
    }
    public class Test{
        static void Main()
        {
            try{
                Console.WriteLine("Enter 1st Number:");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2nd Number:");
                int y = int.Parse(Console.ReadLine());
                if(y % 2 >0)
                {
                    throw new DivideByOddNoException();
                }
                int z = x/y;
                Console.WriteLine("The result is :"+ z);
            }
            catch(DivideByZeroException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch(DivideByOddNoException ex2)
            {
                Console.WriteLine(ex2.Message);
            }
            finally
            {
                Console.WriteLine("End of the program.");
            }
        }
    }
}