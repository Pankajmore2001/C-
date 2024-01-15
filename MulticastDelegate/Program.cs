using System;
namespace MulticastDelegate;
public delegate void RectDelegate(double Width,double Height);
public class Rectangle
{
    public void Area(double Width,double Height)
    {
        Console.WriteLine("Area of Rectangle: "+ Width*Height);
    }
    public void Perimeter(double Width,double Height)
    {
        Console.WriteLine("Perimeter of Rectangle: "+ 2*(Width+Height));
    }
    static void Main(String[] args)
    {
        Rectangle R = new Rectangle();
        RectDelegate RD = R.Area;
       // RD-=R.Perimeter;
        RD(3,4);
    }
}