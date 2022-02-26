using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cau_7
{
    class SinhVien
    {
        //Id, Tên, Số điện thoại, Địa chỉ 

        //Nhap mang
        public static void NhapMang(string[,] mang, int sodong, int socot)
        {


            for (int i = 0; i < sodong; i++)
            {
                for (int j = 0; j < socot; j++)
                {
                    if (j == 0)
                    {
                        Console.Write($"Nhap ID SV {i + 1}: ");
                        mang[i, j] = Console.ReadLine();
                    }
                    if (j == 1)
                    {
                        Console.Write($"Nhap Ten SV {i + 1}: ");
                        mang[i, j] = Console.ReadLine();
                    }

                    if (j == 2)
                    {
                        Console.Write($"Nhap So Dien Thoai SV {i + 1}: ");
                        mang[i, j] = Console.ReadLine();
                    }
                    if (j == 3)
                    {
                        Console.Write($"Nhap Dia Chi SV {i + 1}: ");
                        mang[i, j] = Console.ReadLine();
                    }

                }
                Console.WriteLine("===================================");
            }
        }
        // in mang
        public static void InMang(string[,] mang, int sodong, int socot)
        {
            Console.WriteLine();
            Console.WriteLine("ID\tTen\tPhone\tDiaChi");
            for (int i = 0; i < sodong; i++)
            {
                for (int j = 0; j < socot; j++)
                {
                    Console.Write($"{mang[i, j]}\t");
                }
                Console.WriteLine();
            }

        }

        public static void Capnhatsv(string[,] mang, int sodong, int socot)
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Cap Nhat SV");
        Nhapid:
            Console.Write("Nhap ID SV : ");
            string x = Console.ReadLine();
            bool a = false;
            for (int i = 0; i < sodong; i++)
            {
                for (int j = 0; j < socot; j++)
                {
                    if (mang[i, 0] == x)
                    {
                        a = true;
                        Console.Write("Nhap ten SV: ");
                        mang[i, j + 1] = Console.ReadLine();

                        Console.Write("Nhap sdt SV: ");
                        mang[i, j + 2] = Console.ReadLine();

                        Console.Write("Nhap dia chi SV: ");
                        mang[i, j + 3] = Console.ReadLine();
                        break;
                    }
                }

            }
            if (a == false)
            {
                Console.WriteLine("Nhap sai. Nhap lai");
                Console.WriteLine("===================================");
                goto Nhapid;
            }
        }
        
        public static void Xoasv(string[,] mang, int sodong, int socot)
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Xoa SV");
            bool a = false;
        Nhapid:
            Console.Write("Nhap ID SV Can Xoa : ");
            string x = Console.ReadLine();
            string[,] mang2 = new string[sodong, socot];
            int dem = 0;
            //ktra id
            for (int i = 0; i < sodong; i++)
            {
                if (mang[i, 0] == x)
                {
                    a = true;
                }
            }
            // xoa sv
            if (a == true)
            {
                for ( int i = 0; i < sodong; i++)
                {
                    if (mang[i, 0] != x)
                    {
                        for (int j = 0; j < socot; j++)
                        {
                            mang2[dem, j] = mang[i, j];
                        }
                        dem++;
                    }
                }
            }
            if (a == false)
            {
                Console.WriteLine("Nhap sai ID Nhap lai");
                Console.WriteLine("==================================");
                goto Nhapid;
            }

            // in danh sach sinh vien sau xoa
            Console.WriteLine("Danh sach Sinh Vien sau xoa");
            for (int i = 0; i < sodong-1; i++)
            {
                for (int j = 0; j < socot; j++)
                {
                    Console.Write($"{mang2[i, j]}\t");
                }
                Console.WriteLine();
            }

        }
        public static void Xoasv2(string[,] mang, ref int sodong, int socot)
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Xoa SV Cach 2");
            bool a = false;
            NhapID:
            Console.Write("Nhap ID SV Can Xoa : ");
            string x = Console.ReadLine();
            //==============

            for (int i = 0; i < sodong; i++)
            {
                if (mang[i,0] == x)
                {
                    a = true;
                }
                if (a == true) 
                { 
                    for (int j = 0; j < socot; j++)
                        {
                            if (i < sodong-1)
                            mang[i, j] = mang[i + 1, j];
                            if (i == sodong-1)
                                mang[i, j] = mang[i - 1, j];
                        }
                }
            }
            if (a == false)
            {
                Console.Write("Nhap sai ID nhap lai");
                goto NhapID;
            }
            sodong--;
            // in mang
            for (int i = 0; i < sodong; i++)
            {
                for (int j = 0; j < socot; j++)
                {
                    Console.Write($"{mang[i, j]}\t");
                }
                Console.WriteLine();
            }
        }




    }
}
