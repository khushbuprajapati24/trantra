using System;
using System.Linq;
 
public class Example
{
    public static void Main()
    {
        string str = "geeksforgeeks";
        char ch = 'e';
 
        int freq = str.Count(f => (f == ch));
        Console.WriteLine(freq);
    }
}