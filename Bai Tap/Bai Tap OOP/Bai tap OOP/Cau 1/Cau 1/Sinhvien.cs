using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau_1
{
    //Id, Tên, Số điện thoại, Địa chỉ 
    class Sinhvien
    {
        public string Id { get; set; }
        public string Ten { get; set; }
        public string Dienthoai { get; set; }
        public string Diachi { get; set; }

        public Sinhvien[] SvArr;
        public Sinhvien() {}
        public Sinhvien(int soluong)
        {
            SvArr = new Sinhvien[soluong];
        }
        //================================

        public void Nhapsv(int soluong)
        {
            
            for (int i = 0; i < soluong; i++)
            {
                Sinhvien Addsv = new Sinhvien();
                Console.Write($"Nhap ID SV thu {i +1}: ");
                Addsv.Id = Console.ReadLine();
                Console.Write($"Nhap Ten SV thu {i +1}: ");
                Addsv.Ten = Console.ReadLine();
                Console.Write($"Nhap Dien thoai SV thu {i + 1}: ");
                Addsv.Dienthoai = Console.ReadLine(); 
                Console.Write($"Nhap dia chi SV thu {i + 1}: ");
                Addsv.Diachi = Console.ReadLine();
                Console.WriteLine("=============================");

                SvArr[i] = Addsv ;

            }

        }
      
        public void InSV ()
        {
            Console.WriteLine("Danh sach sinh vien");
            Console.WriteLine("=============================");
            foreach (Sinhvien item in SvArr)
            {
                Console.WriteLine($"ID: {item.Id}\t TenSV: {item.Ten}\t Dienthoai: {item.Dienthoai}\t Diachi: {item.Diachi}");
            }
            Console.WriteLine("=============================");
        }

        public void TimKiemSV()
        {
            Console.Write("Nhap ID sinh vien can tim: ");
            string x = Console.ReadLine();
            bool flag = false;
            for (int i = 0; i < SvArr.Length; i++)
            {
                if(SvArr[i].Id == x)
                {
                    flag = true;
                    Console.WriteLine($"ID: {SvArr[i].Id}\t TenSV: {SvArr[i].Ten}\t Dienthoai: {SvArr[i].Dienthoai}\t Diachi: {SvArr[i].Diachi}");
                    
                }
                
            }
            if (flag == false)
            {
                Console.WriteLine("Nhap sai ID ");
            }
            Console.WriteLine("=============================");
            
        }
        public void CapNhatSV()
        {
            Console.Write("Nhap ID sinh vien cap nhat: ");
            string x = Console.ReadLine();
            bool flag = false;
            for (int i = 0; i < SvArr.Length; i++)
            {
                Sinhvien CapNhat = new Sinhvien();
                if (SvArr[i].Id == x)
                {
                    flag = true;
                    CapNhat.Id = SvArr[i].Id;
                    Console.Write($"Nhap Ten Moi: ");
                    CapNhat.Ten = Console.ReadLine();
                    Console.Write($"Nhap so dien thoai moi: ");
                    CapNhat.Dienthoai = Console.ReadLine();
                    Console.Write($"Nhap dia chi moi: ");
                    CapNhat.Diachi = Console.ReadLine();
                    Console.WriteLine("=============================");
                    SvArr[i] = CapNhat;
                    Console.WriteLine("Sinh vien sau cap nhat: ");
                    Console.WriteLine("=============================");
                }
                
            }
            if (flag == false)
            {
                Console.WriteLine("Nhap sai ID ");
                Console.WriteLine("=============================");
            }
        }
        public void Xoasv()
        {
            
            Console.Write("Nhap ID sinh vien can xoa: ");
            string x = Console.ReadLine();
            Sinhvien[] SvArr2 = (Sinhvien[])SvArr.Clone();
            SvArr = new Sinhvien[SvArr.Length - 1];
            
            int dem = 0;
            for (int i = 0; i < SvArr2.Length; i++)
            {
               if(SvArr2[i].Id != x)
                {
                    SvArr[dem] = SvArr2[i];
                    dem++;
                }
                
            }
            Console.WriteLine("=============================== ");

            
        }


    }
}
