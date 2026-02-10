using System;

class Program
{
    static void Main()
    {
        int a = 10;
        Console.WriteLine(a);
        object obj = a;  		// Boxing
        Console.WriteLine(obj);
        int b = (int)obj;    // Unboxing
        Console.WriteLine(b);
    }
}
