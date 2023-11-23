using System;

public class HelloWorld
{   
    int x;
    static int y = 200;
    const float pi=3.14f;

    readonly bool flag;
    public HelloWorld(int x,bool flag)
    {
        this.x=x;
        this.flag=flag;
    }
    public static void Main(string[] args)
    {   
        HelloWorld h = new HelloWorld(50,true);
        HelloWorld h1 = new HelloWorld(100,false);

        Console.WriteLine (y);
        Console.WriteLine(pi);
        Console.WriteLine (h.x+" "+h1.x);
        Console.WriteLine(h.flag+" "+h1.flag);
    }
}