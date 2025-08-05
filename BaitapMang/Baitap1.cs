using System;

class Baitap1
{
   static void SapXepMang(int[] a, int n)
    {
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (a[i] > a[j])
                {
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
        }
    }
    static void TimPhanTu(int[] a, int n, int k)
    {
        for (int i = 0; i < n; i++)
        {
            if (a[i] == k)
            {
                Console.WriteLine($"Phần tử {k} xuất hiện tại chỉ số {i}");
                return;
            }
        }
        Console.WriteLine($"Phần tử {k} không xuất hiện trong mảng.");
    }
    static void DaoNguocMang(int[] a, int n)
    {
        for(int i = 0; i < n-1; i++)
        {
            for(int j = 0; j < n - i - 1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
            }
        }
    }
    static void XoaPhanTu(int[] a, int n, int k)
    {
        int index = -1;
        for (int i = 0; i < n; i++)
        {
            if (a[i] == k)
            {
                index = i;
                break;
            }
        }
        if (index != -1)
        {
            for (int i = index; i < n - 1; i++)
            {
                a[i] = a[i + 1];
            }
            n--;
            Console.WriteLine($"Đã xóa phần tử {k} khỏi mảng.");
        }
        else
        {
            Console.WriteLine($"Phần tử {k} không tìm thấy trong mảng.");
        }
    }
    static void ChenPhanTu(int[] a, int n, int k, int index)
    {
        if (index < 0 || index > n)
        {
            Console.WriteLine("Chỉ số không hợp lệ.");
            return;
        }
        for (int i = n; i > index; i--)
        {
            a[i] = a[i - 1];
        }
        a[index] = k;
        n++;
        Console.WriteLine($"Đã chèn phần tử {k} vào vị trí {index}.");
    }
    static void TimGiaTriLonNhat(int[] a, int n)
    {
        if (n == 0)
        {
            Console.WriteLine("Mảng rỗng.");
            return;
        }
        int max = a[0];
        for (int i = 1; i < n; i++)
        {
            if (a[i] > max)
            {
                max = a[i];
            }
        }
        Console.WriteLine($"Giá trị lớn nhất trong mảng là: {max}");
    }
    static void TimGiaTriLonNhatCach2(int[] a, int n)
    {
        if (n == 0)
        {
            Console.WriteLine("Mảng rỗng.");
            return;
        }
       
        for (int i = 0; i < n; i++)
        {
            for(int j = i + 1; j < n; j++)
            {
                if (a[i] > a[j])
                {
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
        }
        Console.WriteLine($"Giá trị lớn nhất  trong mảng là: {a[n-1]}");
    }
    static void TimGiaTriNhoNhat(int[] a, int n)
    {
        if (n == 0)
        {
            Console.WriteLine("Mảng rỗng.");
            return;
        }
        int min = a[0];
        for (int i = 1; i < n; i++)
        {
            if (a[i] < min)
            {
                min = a[i];
            }
        }
        Console.WriteLine($"Giá trị nhỏ nhất trong mảng là: {min}");
    }
    static void TimGiaTriNhoNhatCach2(int[] a, int n)
    {
        if (n == 0)
        {
            Console.WriteLine("Mảng rỗng.");
            return;
        }
        for (int i = 0; i < n; i++)
        {
            for(int j = i + 1; j < n; j++)
            {
                if (a[i] < a[j])
                {
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
        }
        Console.WriteLine($"Giá trị nhỏ nhất trong mảng là: {a[n-1]}");
    }
    static void TimGiaTriLonNhi(int[] a, int n)
    {
        if(n == 0)
        {
            Console.WriteLine("Mảng rỗng");
        }
        int max = a[0];
        int secondMax = int.MinValue; 

        for (int i = 1; i < n; i++)
        {
            if (a[i] > max)
            {
                max = a[i];
                secondMax = max;
            }
            else if (a[i] > secondMax && a[i] < max)
            {
                secondMax = a[i];
            }
        }
        Console.WriteLine($"Giá trị lớn nhì trong mảng là: {secondMax}");

    }
    static void TimGiaTriLonNhiCach2(int[] a, int n)
    {
        if (n == 0)
        {
            Console.WriteLine("Mảng rỗng");
            return;
        }
        for (int i = 1; i < n; i++)
        {
           for(int j = i + 1; j < n; j++)
            {
                if (a[i] > a[j])
                {
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;

                }
            }
        }
        for(int i = n - 1; i >= 0; i--)
        {
            if (a[i] < a[n - 1])
            {
                Console.WriteLine($"Giá trị lớn nhì trong mảng là: {a[i]}");
                return;
            }
        }
    }
    static void KiemTraMangDoiXung(int[] a, int n)
    {
        for (int i = 0; i < n / 2; i++)
        {
            if (a[i] != a[n - i - 1])
            {
                Console.WriteLine("Mảng không đối xứng.");
                return;
            }
        }
        Console.WriteLine("Mảng đối xứng.");
    }
    static void DemSoPhanTuDoiXung(int[] a, int n)
    {
        int count = 0;
        for (int i = 0; i < n / 2; i++)
        {
            if (a[i] == a[n - i - 1])
            {
                count++;
            }
        }
        Console.WriteLine($"Số lượng phần tử đối xứng trong mảng là: {count}");
    }   
    static void Main()
    {
        Console.Write("Nhập số phần tử của mảng: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhập phần tử k vào mảng: ");
        int k = int.Parse(Console.ReadLine());

        int[] a = new int[n];
        int count = 0;
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập phần tử a[{i}]: ");
            a[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Mảng bạn vừa nhập là:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i] + " ");
            if(a[i] % 2 != 0)
            {
                count++;
                sum += a[i];
            }


        }
        TimPhanTu(a, n, k);
        SapXepMang(a, n);

        Console.WriteLine("\nMảng sau khi sắp xếp là:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i] + " ");
        }
        DaoNguocMang(a, n);
        Console.WriteLine("\nMảng sau khi đảo ngược là:");
        for (int i = n - 1; i >= 0; i--)
        {
            Console.Write(a[i] + " ");
        }
        XoaPhanTu(a, n, k);
        Console.WriteLine("\nMảng sau khi xóa phần tử " + k + " là:");
        for (int i = 0; i < n - 1; i++)
        {
            Console.Write(a[i] + " ");
        }
        ChenPhanTu(a, n - 1, k, 2);
        Console.WriteLine("\nMảng sau khi chèn phần tử " + k + " vào vị trí 2 là:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i] + " ");
        }
        TimGiaTriLonNhat(a, n);
        Console.WriteLine("\nMảng sau khi thực hiện các thao tác là:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i] + " ");
        }
        TimGiaTriLonNhatCach2(a, n);
        TimGiaTriNhoNhat(a, n);
        TimGiaTriNhoNhatCach2(a, n);
        TimGiaTriLonNhi(a, n);
        TimGiaTriLonNhiCach2(a, n);
        KiemTraMangDoiXung(a, n);
        DemSoPhanTuDoiXung(a, n);
        Console.WriteLine("\nSố lượng phần tử lẻ trong mảng là: " + count);
        Console.WriteLine("Tổng các phần tử lẻ trong mảng là: " + sum);
    }
    
}

