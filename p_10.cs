using System;

class Program
{
    static void Main()
    {
        int[] a = new int[5];

        for (int i = 0; i < a.Length; i++)
        {
            Console.Write("Enter value of {0}= ",i);
            a[i] = int.Parse(Console.ReadLine());
        }

       foreach (int i in a){
	   Console.WriteLine("value is :{0}",i);
	   }
    }
}
