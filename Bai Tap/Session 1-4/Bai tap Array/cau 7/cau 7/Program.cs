using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cau_7
{
    class Program
    {
        //static void NhapMang(int[,] SinhVien)
        static void Main(string[] args)
        {
            
            Console.Write("Nhap so dong: ");
            int sodong = int.Parse(Console.ReadLine());
            int socot = 4;
            Console.WriteLine("===================================");
            string[,] mang = new string[sodong, socot];

            // nhap mang
            SinhVien.NhapMang(mang, sodong, socot);

            // in mang
            Console.WriteLine("Danh sach Sinh Vien");
            SinhVien.InMang(mang, sodong, socot);

            //cap nhat sv
            //SinhVien.Capnhatsv(mang, sodong, socot);
            //Console.WriteLine("===================================");

            //in mang sau khi cap nhat
            //Console.WriteLine("Danh sach Sinh Vien Cap Nhat");
            //SinhVien.InMang(mang, sodong, socot);

            //xoa sv
            SinhVien.Xoasv2(mang,ref sodong, socot);

            Console.ReadKey();


        }
        
    }
        
}

