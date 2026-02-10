using System;

class Duplicate2D
{
    static void Main()
    {
        int[,] a = new int[2, 3];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("Enter value : ");
                a[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                int count = 0;
                for (int x = 0; x < 2; x++)
                {
                    for (int y = 0; y < 3; y++)
                    {
                        if (a[i, j] == a[x, y])
                            count++;
                    }
                }
                Console.WriteLine(a[i, j] + " count : " + count);
            }
        }
    }
}
