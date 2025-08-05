class BaitapMangSinhVien
{
    static void TimTenChinhXac(string[] hoten, int n)
    {
        string name = Console.ReadLine();
        for (int i = 0; i < n; i++)
        {
            if (hoten[i] == name)
            {
                Console.WriteLine($"Tên chính ác: {hoten[i]}");
                return;
            }
        }
        Console.WriteLine("Không tìm thấy tên chính ác.");
    }
    static void TimTenKhongChinhXac(string[] hoten, int n)
    {
        string name = Console.ReadLine().ToLower();
        for (int i = 0; i < n; i++)
        {
            if (hoten[i].ToLower().Contains(name))
            {
                Console.WriteLine($"Tên không chính xác: {hoten[i]}");
            }
        }
        Console.WriteLine("Không tìm thấy tên không chính xác nào.");
    }

    static void SapXepTuoiTangDan(int[] tuoi, string[] hoten, string[] gioitinh, double[] diemtb, int n)
    {
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (tuoi[i] > tuoi[j])
                {
                    int tempTuoi = tuoi[i];
                    tuoi[i] = tuoi[j];
                    tuoi[j] = tempTuoi;
                }
            }
        }
        Console.WriteLine("\n Danh sách được sắp xếp tuổi ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(" -Ten cua hoc vien" + hoten[i]);
            Console.Write(" - Gioi tinh: " + gioitinh[i]);
            Console.Write(" - Tuoi: " + tuoi[i]);
            Console.WriteLine(" - Diem trung binh: " + diemtb[i]);
        }
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhập số lượng sinh viên:");
        int n = int.Parse(Console.ReadLine());
        string[] hoten = new string[n];
        string[] gioitinh = new string[n];
        int[] tuoi = new int[n];
        double[] diemtb = new double[n];

        int i = 0;
        do
        {
            Console.WriteLine($"/n Nhap thong tin cho nhan vien thu {i + 1}");
            Console.Write("Họ tên: ");
            hoten[i] = Console.ReadLine();
            Console.Write("Giới tính (Nam/Nữ): ");
            gioitinh[i] = Console.ReadLine();
            Console.Write("Tuổi: ");
            while (true)
            {
                try
                {
                    tuoi[i] = int.Parse(Console.ReadLine());
                    if (tuoi[i] < 0)
                    {
                        Console.WriteLine("Tuổi không thể là số âm. Vui lòng nhập lại.");
                        continue;
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Vui lòng nhập một số nguyên hợp lệ cho tuổi.");
                }
            }
            Console.Write("Điểm trung bình: ");
            diemtb[i] = double.Parse(Console.ReadLine());
            i++;
        }
        while (i < n);
        double max1 = double.MinValue;
        double max2 = double.MinValue;
        int indexMax1 = -1;
        int indexMax2 = -1;

        for (int j = 0; j < n; j++)
        {
            if (diemtb[j] > max1)
            {
                max2 = max1;
                indexMax2 = indexMax1;

                max1 = diemtb[j];
                indexMax1 = j;
            }
            else if (diemtb[j] > max2)
            {
                max2 = diemtb[j];
                indexMax2 = j;
            }
        }

        Console.WriteLine("\n--- Nhân viên có điểm trung bình cao nhất ---");
        Console.WriteLine($"Họ tên: {hoten[indexMax1]}");
        Console.WriteLine($"Giới tính: {gioitinh[indexMax1]}");
        Console.WriteLine($"Tuổi: {tuoi[indexMax1]}");
        Console.WriteLine($"Điểm trung bình: {diemtb[indexMax1]}");

        Console.WriteLine("\n--- Nhân viên có điểm trung bình cao nhì ---");
        Console.WriteLine($"Họ tên: {hoten[indexMax2]}");
        Console.WriteLine($"Giới tính: {gioitinh[indexMax2]}");
        Console.WriteLine($"Tuổi: {tuoi[indexMax2]}");
        Console.WriteLine($"Điểm trung bình: {diemtb[indexMax2]}");
        Console.WriteLine("\n--- Tìm tên chính xác ---");
        TimTenChinhXac(hoten, n);
        Console.WriteLine("\n--- Tìm tên không chính xác ---");
        TimTenKhongChinhXac(hoten,n);
        Console.WriteLine("\n--- Sắp xếp theo tuổi tăng dần ---");
        SapXepTuoiTangDan(tuoi, hoten, gioitinh, diemtb, n);
    }
}