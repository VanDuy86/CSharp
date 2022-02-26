using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tap_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mang = new int[10];
            int n;
            Console.Write("Nhap so phan tu cua mang (Toi da 10 phan tu): ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Mang co {n} phan tu");
            //nhap mang
            BaiTapArray.NhapMang(mang, n);
            
            // in mang
            BaiTapArray.InMang (mang, n);

            //cau 2 tong cua tat ca phan tu
            int Tong = BaiTapArray.TongPhanTu(mang, n);
            Console.WriteLine($"Tong cua tat ca phan tu la: {Tong}");
            Console.WriteLine();

            // cau 3 tim so phan tu giong nhau trong mang
            BaiTapArray.PhanTuGiongNhau(mang, n);

            // cau 6 Tìm giá trị lớn nhất (max) của dãy và in ra vị trí của các phần tử có giá trị = max.
            BaiTapArray.TimMax(mang, n);

            //cau 6 Cho người dùng nhập 1 số x từ bàn phím, tìm và in ra vị trí của phần tử  trong dãy có giá trị bằng  x.
            int y;
            Console.WriteLine();
            Console.Write("Nhap so can tim vi tri: ");
            y = Convert.ToInt32(Console.ReadLine());
            BaiTapArray.TimViTri(mang, n, y);

            // cau 5 sap xep Giam
            BaiTapArray.SapXepGiam(mang, n);
            Console.WriteLine("sap xep giam");
            BaiTapArray.InMang(mang, n);

            //cau 4 dem so lan xuat hien cua phan tu
            BaiTapArray.DemSoLanXuatHien(mang, n);
            Console.ReadKey();
        }
    }
}
