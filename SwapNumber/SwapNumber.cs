using System;
 
public class SwapNumber
{
    public static void Main()
    {
        int a = 10, b = 50;
 
        (a, b) = (b, a);
 
        Console.WriteLine("a={0}, b={1}", a, b);
    }
}