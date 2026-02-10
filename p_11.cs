using System;

class ArrayExample
{
    static void Main()
    {
		Console.Write("enter size of array:");
        int[] a = new int[int.Parse(Console.ReadLine())];

        for (int i = 0; i < a.Length; i++)
        {
            Console.Write("Enter value of {0}: ",i);
            a[i] = int.Parse(Console.ReadLine());
        }

		int sum=0;
		
		for (int i = 0; i < a.Length; i++) 
		{
			Console.Write("Enter value of {0} is :{1}",i,a[i]);
			sum =a[i];
		}
		Console.WriteLine("sum of array element is :"+sum);
    }
}
