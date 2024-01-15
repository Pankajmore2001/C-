using System;
namespace ENUM{
    public enum Days
    {
        Monday,Tuesday,Wednesday,Thursday,Friday
    }
    public class TestClass
    {
        public static void Main(String[] args)
        {
            foreach(string s in Enum.GetNames(typeof(Days)))
            {
                Console.WriteLine(s);
            }
        }
    }
}