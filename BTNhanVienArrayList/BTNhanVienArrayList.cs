using System;
using System.Collections;

class BTNhanVienArrayList
{
    static void DiemTBMax(string[] hoten,string[] gioitinh,int[] tuoi, float[] diemTB)
    {
        if (hoten.Length == 0 || diemTB.Length == 0)
        {
            Console.WriteLine("Danh sách trống.");
            return;
        }

        float max = diemTB[0];
        int indexMax = 0;

        for (int i = 1; i < diemTB.Length; i++)
        {
            if (diemTB[i] > max)
            {
                max = diemTB[i];
                indexMax = i;
            }
        }

        Console.WriteLine($"Nhân viên có điểm trung bình cao nhất là: {hoten[indexMax]} có tuổi : {tuoi[indexMax]} và giới tính : {gioitinh[indexMax]} với điểm: {max}");
    }
    static void DiemTBNhoNhi(string[] hoten, string[] gioitinh, int[] tuoi, float[] diemTB)
    {
        if (hoten.Length < 2 || diemTB.Length < 2)
        {
            Console.WriteLine("Danh sách không đủ nhân viên để tìm điểm trung bình nhỏ nhì.");
            return;
        }
        float max = float.MinValue, secondMax = float.MinValue;
        int indexMax = -1, indexSecondMax = -1;
        for (int i = 0; i < diemTB.Length; i++)
        {
            if (diemTB[i] > max)
            {
                secondMax = max;
                indexSecondMax = indexMax;
                max = diemTB[i];
                indexMax = i;
            }
            else if (diemTB[i] > secondMax && diemTB[i] < max)
            {
                secondMax = diemTB[i];
                indexSecondMax = i;
            }
        }
        if (indexSecondMax != -1)
        {
            Console.WriteLine($"Nhân viên có điểm trung bình nhỏ nhì là: {hoten[indexSecondMax]} có tuổi : {tuoi[indexSecondMax]} và giới tính : {gioitinh[indexSecondMax]} với điểm: {secondMax}");
        }
        else
        {
            Console.WriteLine("Không có điểm trung bình nhỏ nhì trong danh sách.");
        }
    }
    static void SapXepNhanVienTheoTuoiTangDan(int[] tuoi, string[] hoten, string[] gioitinh, float[] diemTB)
    {
        for (int i = 0; i < tuoi.Length - 1; i++)
        {
            for (int j = i + 1; j < tuoi.Length; j++)
            {
                if (tuoi[i] > tuoi[j])
                {
                    int tempTuoi = tuoi[i];
                    tuoi[i] = tuoi[j];
                    tuoi[j] = tempTuoi;
                }
            }
        }
        Console.WriteLine("\n--- Danh sách nhân viên sắp xếp theo tuổi tăng dần ---");
        for (int i = 0; i < tuoi.Length; i++)
        {
            Console.WriteLine($"Nhân viên {i + 1}: {hoten[i]}, {gioitinh[i]}, {tuoi[i]} tuổi, ĐTB: {diemTB[i]}");
        }
    }

    static void Main(string[] args)
    {
        ArrayList hoTen = new ArrayList();
        ArrayList gioiTinh = new ArrayList();
        ArrayList tuoi = new ArrayList();
        ArrayList diemTB = new ArrayList();

        int n = 0;

        Console.Write("Nhập số lượng nhân viên: ");
        n = int.Parse(Console.ReadLine());

        int i = 0;
        do
        {
            Console.WriteLine($"\n--- Nhập thông tin nhân viên thứ {i + 1} ---");

            Console.Write("Họ tên: ");
            hoTen.Add(Console.ReadLine());

            Console.Write("Giới tính: ");
            gioiTinh.Add(Console.ReadLine());

            Console.Write("Tuổi: ");
            tuoi.Add(int.Parse(Console.ReadLine()));

            Console.Write("Điểm trung bình: ");
            diemTB.Add(float.Parse(Console.ReadLine()));

            i++;
        } while (i < n);

        // In danh sách nhân viên đã nhập
        Console.WriteLine("\n--- DANH SÁCH NHÂN VIÊN ---");
        for (int j = 0; j < n; j++)
        {
            Console.WriteLine($"Nhân viên {j + 1}: {hoTen[j]}, {gioiTinh[j]}, {tuoi[j]} tuổi, ĐTB: {diemTB[j]}");
        }
        Console.WriteLine("\n--Danh sách có dtb cao nhất");
        DiemTBMax((string[])hoTen.ToArray(typeof(string)), (string[])gioiTinh.ToArray(typeof(string)), (int[])tuoi.ToArray(typeof(int)), (float[])diemTB.ToArray(typeof(float)));
        Console.WriteLine("\n--Danh sách có dtb nhỏ nhì");
        DiemTBNhoNhi((string[])hoTen.ToArray(typeof(string)), (string[])gioiTinh.ToArray(typeof(string)), (int[])tuoi.ToArray(typeof(int)), (float[])diemTB.ToArray(typeof(float)));
        SapXepNhanVienTheoTuoiTangDan((int[])tuoi.ToArray(typeof(int)), (string[])hoTen.ToArray(typeof(string)), (string[])gioiTinh.ToArray(typeof(string)), (float[])diemTB.ToArray(typeof(float)));
    }
}
