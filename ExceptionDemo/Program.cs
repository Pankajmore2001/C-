using System;
namespace ExceptionDemo;
class Demo{
    public static void Main(string[] args)
    {
        try{
            Console.WriteLine("Enter 1st integer value:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd integer value:");
            int y = int.Parse(Console.ReadLine());
            int z = x/y;
            Console.WriteLine("The Result is : "+z);
       }
        catch(DivideByZeroException ex1)
        {
            Console.WriteLine(ex1.Message);
        }
        catch(FormatException ex2)
        {
            Console.WriteLine(ex2.Message);
        }
        catch(OverflowException ex3)
        {
            Console.WriteLine(ex3.Message);
        }
        catch( Exception ex)        //Default catch block which can catch any exception 
        {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine("End of the Program");
    }

}