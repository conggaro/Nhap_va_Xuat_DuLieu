// Yêu cầu:
// 1. nhập tên
// 2. nhập tuổi
// 3. in ra màn hình dữ liệu vừa nhập

// Để chạy 1 chương trình C#
// Bước 1: "dotnet new console" để tạo chương trình
// Bước 2: "dotnet run" để chạy chương trình

using System;

namespace MyApp     // chỗ này đặt tên namespace tùy ý
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // nhập tên
            Console.Write("Nhap ten: ");
            string? ten = Console.ReadLine();

            // nhập tuổi
            Console.Write("Nhap tuoi: ");
            int tuoi = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nKet qua:\n");
            Console.Write("Ten: " + ten + "\n");
            Console.Write("Tuoi: " + tuoi + "\n");
        }
    }
}