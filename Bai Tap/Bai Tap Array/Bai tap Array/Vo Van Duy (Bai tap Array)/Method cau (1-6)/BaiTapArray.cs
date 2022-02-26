using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tap_Method
{
     class BaiTapArray
    {
        // cau 2 Nhap mang
        public static void NhapMang(int[] mang, int n)
        {

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Phan tu thu [{i}]: ");
                mang[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

        }

        // in mang
        public static void InMang(int[] mang, int n)
        {
            Console.Write("So phan tu cua mang: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"\t {mang[i]} ");
            }
            Console.WriteLine();
        }

        // cau 2 tong cua tat ca phan tu
        public static int TongPhanTu(int[] mang, int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong += mang[i];
            }
            return tong;
        }
        // cau 3 tim so phan tu giong nhau trong mang 
        public static void PhanTuGiongNhau(int[] mang, int n)
        {
            bool a = false;
            for (int i = 0; i < n; i++)
            {
                
                for (int j = i + 1; j < n; j++)
                {
                    if (mang[i] == mang[j])
                    {
                        a = true;
                        Console.WriteLine($"Phan tu giong nhau la so : {mang[i]}");
                    }
                }
                
            }
            Console.WriteLine();
            if (a == false)
            {
                Console.WriteLine("Mang khong co phan tu giong nhau");
                Console.WriteLine();
            }
        }
        // cau 4 dem so lan xuat hien cua phan tu
        public static void DemSoLanXuatHien(int[] mang, int n)
        {
            Console.WriteLine();

            for (int i = 0; i<n; i++)
            {
                int dem = 1;
                int b = i;
                for (int j = i+1; j<n; j++)
                {
                    if (mang[b] == mang[j])
                    {
                        dem++;
                        b++;
                    }
                }
                i = b;
                Console.WriteLine($"So lan xuat hien cua {mang[i]} la {dem} lan");
            }
            
        }


        // cau 5 sap xep Giam
        public static void SapXepGiam(int[] mang, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (mang[j] > mang[i])
                    {
                        int a = mang[j];
                        mang[j] = mang[i];
                        mang[i] = a;
                    }
                }
            }
            Console.WriteLine();
        }
        // cau 6 Tìm giá trị lớn nhất (max) của dãy và in ra vị trí của các phần tử có giá trị = max.
        public static void TimMax(int[] mang, int n)
        {
            int max = mang[0];
            for (int i = 0; i < n; i++)
            {
                if (max < mang[i])
                {
                    max = mang[i];
                    
                }
            }
            Console.WriteLine($"So lon nhat la : {max}");
            Console.WriteLine();
            //tim vi tri cua max
            for (int i = 0; i < n; i++)
            {
                if (max == mang[i])
                {
                    Console.WriteLine($"Vi tri so lon nhat la : {i}");
                }
            }
            Console.WriteLine();
        }
      
        //cau 6 Cho người dùng nhập 1 số x từ bàn phím, tìm và in ra vị trí của phần tử  trong dãy có giá trị bằng  x.
        public static void TimViTri (int[] mang, int n, int y)
        {
            bool a = false;
            for (int i = 0; i < n; i++)
            {
                if (y == mang[i])
                {
                    a = true;
                    Console.WriteLine($"Vi tri cua {y} la: {i}");
                }
            }
            if (a == false)
            {
                Console.WriteLine($"{y} khong co trong mang");
                Console.WriteLine();
            }
        }
       
    }
}
