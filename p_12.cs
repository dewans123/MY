using System;

class TwoDArray
{
    static void Main()
    {
        Console.Write("Enter row size : ");
        int r = int.Parse(Console.ReadLine());

        Console.Write("Enter column size : ");
        int c = int.Parse(Console.ReadLine());

        int[,] a = new int[r, c];

        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.Write("Enter value of [" + i + "," + j + "] : ");
                a[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.Write(a[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
