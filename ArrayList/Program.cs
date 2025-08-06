using System;
using System.Collections;
class BTArrayList
{
    static void Timphantu(int[] a, int k)
    {
        bool found = false;
        foreach (int item in a)
        {
            if (item == k)
            {
                found = true;
                break;
            }
        }
        if (found)
        {
            Console.WriteLine($"Phần tử {k} có trong mảng.");
        }
        else
        {
            Console.WriteLine($"Phần tử {k} không có trong mảng.");
        }
    }
    static void SapXepTangDan(int[] a)
    {
        Array.Sort(a);
        Console.WriteLine("Mảng đã sắp xếp theo thứ tự tăng dần:");
        foreach (int item in a)
        {
            Console.Write(item + " ");
        }
    }
    static void DaoNguocMang(int[] a)
    {
        Array.Reverse(a);
        Console.WriteLine("Mảng đã đảo ngược:");
        foreach (int item in a)
        {
            Console.Write(item + " ");
        }
    }
    static void XoaPhanTu(int[] a, int k)
    {
        ArrayList list = new ArrayList(a);
        if (list.Contains(k))
        {
            list.Remove(k);
            Console.WriteLine($"Phần tử {k} đã được xóa khỏi mảng.");
        }
        else
        {
            Console.WriteLine($"Phần tử {k} không có trong mảng để xóa.");
        }
        Console.WriteLine("Mảng sau khi xóa:");
        foreach (int item in list)
        {
            Console.Write(item + " ");
        }
    }
    static void TimGiaTriLonNhat(int[] a)
    {
        if (a.Length == 0)
        {
            Console.WriteLine("Mảng rỗng.");
            return;
        }
        int max = a[0];
        foreach (int item in a)
        {
            if (item > max)
            {
                max = item;
            }
        }
        Console.WriteLine($"Giá trị lớn nhất trong mảng là: {max}");
    }
    static void TimGIaTriLonNhit(int[] a)
    {
        if (a.Length < 2)
        {
            Console.WriteLine("Mảng không đủ phần tử để tìm giá trị lớn nhì.");
            return;
        }
        int max = int.MinValue, secondMax = int.MinValue;
        foreach (int item in a)
        {
            if (item > max)
            {
                secondMax = max;
                max = item;
            }
            else if (item > secondMax && item < max)
            {
                secondMax = item;
            }
        }
        if (secondMax == int.MinValue)
        {
            Console.WriteLine("Không có giá trị lớn nhì trong mảng.");
        }
        else
        {
            Console.WriteLine($"Giá trị lớn nhì trong mảng là: {secondMax}");
        }
    }
    static void Main(string[] args)
    {
        ArrayList a = new ArrayList();
        Console.Write("Nhập số lượng phần tử n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1}: ");
            int value = int.Parse(Console.ReadLine());
            a.Add(value);
        }
        Console.WriteLine("\nCác phần tử trong ArrayList:");
        foreach (int item in a)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("Nhập phần tử cần tìm trong k: ");
        int k = int.Parse(Console.ReadLine());
        int countOdd = 0;
        int sum = 0;
        foreach (int item in a)
        {
            if (item > 0 && item % 2 != 0)
            {
                sum += item;
                countOdd++;
            }
        }
        Timphantu((int[])a.ToArray(typeof(int)), k);
        SapXepTangDan((int[])a.ToArray(typeof(int)));
        DaoNguocMang((int[])a.ToArray(typeof(int)));
        XoaPhanTu((int[])a.ToArray(typeof(int)), k);
        TimGiaTriLonNhat((int[])a.ToArray(typeof(int)));
        TimGIaTriLonNhit((int[])a.ToArray(typeof(int)));
        Console.WriteLine($"\n\nSố lượng phần tử lẻ trong ArrayList: {countOdd}");
        Console.WriteLine($"Tổng các phần tử lẻ trong ArrayList: {sum}");
    }
}

