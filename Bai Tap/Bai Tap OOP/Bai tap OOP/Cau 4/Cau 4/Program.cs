using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong khach hang: ");
            int SLKH = int.Parse(Console.ReadLine());

            HanhKhach objHanhKhach = new HanhKhach(SLKH);
            objHanhKhach.NhapKH(SLKH);

            do
            {
                Console.WriteLine("1. In Khach Hang");
                Console.WriteLine("2. Sap xep giam theo tong tien");
                Console.WriteLine("3. Thoat");
                Console.Write("Nhap tuy chon: ");
                int chon = int.Parse(Console.ReadLine());
                if (chon == 1)
                {
                    Console.WriteLine("In Khach Hang");
                    Console.WriteLine("=============================================================================");
                    objHanhKhach.InKH();
                }
                if (chon == 2)
                {
                    Console.WriteLine("Sap xep giam theo tong tien");
                    Console.WriteLine("=============================================================================");
                    objHanhKhach.SapXepGiamTheoTongTien();
                    objHanhKhach.InKH();


                }
                if (chon == 3)
                {
                    return;
                }

            } while (true);


            //Console.ReadKey();
            

            




            
        }
    }
}
