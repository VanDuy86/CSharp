using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau_2
{
    //2.	Xây dựng lớp Phanso gồm: tuso, mauso.
            //-	Phương thức:
            //- Hàm Khởi Tạo Không Tham Số, Hàm Hủy
            //- Nhập, Xuất
            //- Cong(), Tru(), Nhan(), Chia()
            //-	Tính Tổng, Hiệu, Tích, Thương 2 phân số obj1 và obj2 rồi in kết quả ra màn hình

    class Program
    {
        static void Main(string[] args)
        {
            Phanso obj1 = new Phanso();
            Phanso obj2 = new Phanso();
            Phanso KetQua = new Phanso();
            

            // ps thu 1
            Console.WriteLine("Nhap phan so thu 1 : ");
            obj1.NhapPhanSo();
            Console.WriteLine($"Phan so thu 1 la {obj1.tuso}/{obj1.mauso}");
            Console.WriteLine("=========================");


            // ps thu 2
            Console.WriteLine("Nhap phan so thu 2 : ");
            obj2.NhapPhanSo();
            Console.WriteLine($"Phan so thu 2 la {obj2.tuso}/{obj2.mauso}");
            Console.WriteLine("=========================");

            //chon phep tinh
            Console.WriteLine("Chon phep tinh");
            Console.WriteLine("1. Tinh Tong");
            Console.WriteLine("2. Tinh Hieu");
            Console.WriteLine("3. Tinh Tich");
            Console.WriteLine("4. Tinh Thuong");
            Nhapso:
            Console.Write("Nhap so (1-4): ");
            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    // tinh tong
                    Console.Write($"Tong 2 phan so la: ");
                    KetQua = KetQua.Tong(obj1, obj2);
                    KetQua.InPhanSo();
                    Console.WriteLine();
                    Console.WriteLine("=========================");
                    break;

                case 2:
                    // Hieu
                    Console.Write($"Hieu 2 phan so la: ");
                    KetQua = KetQua.Hieu(obj1, obj2);
                    KetQua.InPhanSo();
                    Console.WriteLine();
                    Console.WriteLine("=========================");
                    break;

                case 3:
                    // Tich
                    Console.Write($"Tich 2 phan so la: ");
                    KetQua = KetQua.Tich(obj1, obj2);
                    KetQua.InPhanSo();
                    Console.WriteLine();
                    Console.WriteLine("=========================");
                    break;

                case 4:
                    // Thuong
                    Console.Write($"Thuong 2 phan so la: ");
                    KetQua = KetQua.Thuong(obj1, obj2);
                    KetQua.InPhanSo();
                    Console.WriteLine();
                    Console.WriteLine("=========================");
                    break;

                default:
                    Console.WriteLine("Nhap sai nhap lai");
                    Console.WriteLine("=========================");
                    goto Nhapso;
            };

            

            

            

            


            Console.ReadKey();
        }
    }
}
