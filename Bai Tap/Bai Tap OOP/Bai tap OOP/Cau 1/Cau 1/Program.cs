using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau_1
{
    //1. Viết chương trình C# sử dụng mảng và class để nhập, lưu trữ sinh viên ( Id, Tên, Số điện thoại, Địa chỉ ) và in danh sách sinh viên lên màn hình .
    //Sau đó thực hiện các yêu cầu sau:

    //-	Thêm mới sinh viên
    //-	Tìm kiếm và hiển thị sinh viên
    //-	Đếm số sinh viên
    //-	Cập nhật thông tin sinh viên theo Id
    //-	Xóa sinh viên theo Id
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong SV: ");
            int SoLuong = int.Parse(Console.ReadLine());
            Console.WriteLine("=============================");
            //Sinhvien[] SvArr = new Sinhvien[SoLuong];
            Sinhvien objSV = new Sinhvien(SoLuong);

            // Nhap SV
            objSV.Nhapsv(SoLuong);

            do
            {
                Console.WriteLine("1. In SV");
                Console.WriteLine("2. Tim kiem SV");
                Console.WriteLine("3. Cap nhat SV");
                Console.WriteLine("4. Xoa SV");
                Console.WriteLine("5. Thoat");
                Console.Write("Nhap So: ");
                int x = int.Parse(Console.ReadLine());
                //=====================================
                
                if (x == 1)
                {
                    Console.WriteLine("====In SV===");
                    objSV.InSV();
                }
                if (x == 2)
                {
                    Console.WriteLine("====Tim kiem SV===");
                    objSV.TimKiemSV();
                }
                if (x == 3)
                {
                    Console.WriteLine("====Cap nhat SV===");
                    objSV.CapNhatSV();
                }
                if (x == 4)
                {
                    Console.WriteLine("====Xoa SV===");
                    objSV.Xoasv();
                }
                if (x == 5)
                {
                    return;
                }
            } while (true);
            
           

            

            Console.ReadKey();
        }
    }
}
