using System;
namespace Properties{
    public class Circle
    {
        public double _Radius = 12.34;
        public double Radius
        {
            get{return _Radius;}    //Represent a value returnig method without parameter
            set                     //Represent a non-value returning method with parameter
            {
                if(value>_Radius)
                _Radius = value;
            }
        }
    }
    public class TestCircle
    {
        static void Main()
        {
            Circle c = new Circle();
            double radius = c.Radius;
            Console.WriteLine(radius);
            c.Radius = 12.33;
            Console.WriteLine(c._Radius);
        }
    }

}