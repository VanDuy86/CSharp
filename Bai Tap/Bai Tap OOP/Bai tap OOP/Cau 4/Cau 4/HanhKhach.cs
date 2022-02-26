using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau_4
{
    class HanhKhach : Nguoi
    {
        HanhKhach() { }
        public int tongtien { get; set; }
       
        public HanhKhach[] KhachHang;
        public HanhKhach(int SLKH)
        {
            KhachHang = new HanhKhach[SLKH];
        }
       
        ~HanhKhach() {}
        //======================

        int SLVe = 0;
        public int TongTien()
        {

            tongtien = getgiave() * SLVe;
            return tongtien;
        }

        public void NhapKH(int SLKH)
        {
            

            for (int i = 0; i < SLKH; i++)
            {
                HanhKhach Nhap = new HanhKhach();

                Console.Write("Nhap ho ten: ");
                Nhap.hoten = Console.ReadLine();

                Console.Write("Nhap gioi tinh: ");
                Nhap.gioitinh = Console.ReadLine();

                Console.Write("Nhap tuoi: ");
                Nhap.tuoi = int.Parse(Console.ReadLine());

                Console.Write("Nhap chuyen bay: ");
                Nhap.tenchuyen = Console.ReadLine();

                Console.Write("Nhap ngay bay: ");
                Nhap.ngaybay = Console.ReadLine();

                Console.Write("Nhap so luong ve: ");
                SLVe = int.Parse(Console.ReadLine());
                Nhap.soluongve = SLVe;

                Nhap.giave = getgiave();
                //Nhap.tongtien = TongTien(); cach 1 ok
                Nhap.tongtien = Nhap.soluongve * Nhap.getgiave();
                Console.WriteLine("=============================================================================");
                KhachHang[i] = Nhap;
            }
        }
        public void InKH()
        {
            foreach (HanhKhach item in KhachHang)
            {
                Console.WriteLine($"Ho Ten: {item.hoten}");
                Console.WriteLine($"Tuoi: {item.tuoi}");
                Console.WriteLine($"Gioi Tinh: {item.gioitinh}");
                Console.WriteLine($"Nhap chuyen bay: {item.tenchuyen}");
                Console.WriteLine($"Ngay Bay: {item.ngaybay}");
                Console.WriteLine($"So Luong Ve: {item.soluongve}");
                Console.WriteLine($"Gia ve: {item.giave}");
                Console.WriteLine($"Tong Tien: {item.tongtien}");
                Console.WriteLine("=============================================================================");

            }
        }

        private class TongTienCompare : IComparer
        {
            public int Compare(object x, object y)
            {
                var objTongTien = new CaseInsensitiveComparer();
               return objTongTien.Compare(((HanhKhach)x).tongtien, ((HanhKhach)y).tongtien);
                //objTongTien.Compare(((HanhKhach)x).TongTien(), ((HanhKhach)y).TongTien()); tong tien cach 1
            }
        }
        public void SapXepGiamTheoTongTien()
        {
            Array.Sort(KhachHang, new TongTienCompare());
            Array.Reverse(KhachHang);
        }


    }
}
