using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhập số dòng m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Nhập số cột n: ");
        int n = int.Parse(Console.ReadLine());

        int[,] A = new int[m, n];

        Console.WriteLine("Nhập các phần tử của ma trận A:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"A[{i},{j}] = ");
                A[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nMa trận A:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(A[i, j] + "\t");
            }
            Console.WriteLine();
        }

        int tich = 1;
        bool coBoiso3 = false;
        for (int j = 0; j < n; j++)
        {
            if (A[0, j] % 3 == 0)
            {
                tich *= A[0, j];
                coBoiso3 = true;
            }
        }

        if (coBoiso3)
        {
            Console.WriteLine($"\nTích các số là bội số của 3 trên dòng đầu tiên: {tich}");
        }
        else
        {
            Console.WriteLine("\nKhông có số nào là bội số của 3 trên dòng đầu tiên.");
        }

        int[] X = new int[m];
        for (int i = 0; i < m; i++)
        {
            int max = A[i, 0];
            for (int j = 1; j < n; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                }
            }
            X[i] = max;
        }

        Console.WriteLine("\nMảng X chứa giá trị lớn nhất của từng dòng:");
        for (int i = 0; i < m; i++)
        {
            Console.Write(X[i] + " ");
        }
    }
}
