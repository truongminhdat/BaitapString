using System;

class Program
{
    static void Main()
    {
        // ======= HÌNH 1 =======
        Console.WriteLine("Hình 1:\n");

        int h1_rows = 7; 
        int h1_cols = 6; 

        char[,] h1 = new char[h1_rows, h1_cols];

        for (int i = 0; i < h1_rows; i++)
        {
            for (int j = 0; j < h1_cols; j++)
            {
                if (i == 0 || i == h1_rows - 1 || j == 0 || j == h1_cols - 1)
                {
                    h1[i, j] = '*';
                }
                else
                {
                    h1[i, j] = ' ';
                }
            }
        }

        // In hình 1
        for (int i = 0; i < h1_rows; i++)
        {
            for (int j = 0; j < h1_cols; j++)
            {
                Console.Write(h1[i, j]);
            }
            Console.WriteLine();
        }

        Console.WriteLine("--------------" +
            ""); 

        // ======= HÌNH 2 =======
        Console.WriteLine("Hình 2:\n");

        int h2_size = 6;
        char[,] h2 = new char[h2_size, h2_size];

        for (int i = 0; i < h2_size; i++)
        {
            for (int j = 0; j < h2_size; j++)
            {
                if (i == 0 || i == h2_size - 1) 
                {
                    h2[i, j] = '*';
                }
                else if (j == i) 
                {
                    h2[i, j] = '*';
                }
                else
                {
                    h2[i, j] = ' ';
                }
            }
        }

        // In hình 2
        for (int i = 0; i < h2_size; i++)
        {
            for (int j = 0; j < h2_size; j++)
            {
                Console.Write(h2[i, j]);
            }
            Console.WriteLine();
        }
    }
}
