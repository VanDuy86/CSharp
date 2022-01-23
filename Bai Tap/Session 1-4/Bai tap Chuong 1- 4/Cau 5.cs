using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau_5
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Console.WriteLine("Dieu Kien : Tong diem thi 3 mon >= 20 diem . Thi sinh trung tuyen");
            Console.WriteLine("-----------------------------------------------------------------");
            int Toan, Ly, Hoa;
            // Nhap diem thi 3 mon 
            
            Console.WriteLine("nhap so Diem");
            Console.Write("Nhap diem mon Toan: ");
            Toan = Convert.ToInt32(Console.ReadLine());

            // kiem tra diem nhap vao
            if (Toan >= 11)
            {
                return;
            }
            Console.Write("Nhap diem mon Ly: ");
            Ly = Convert.ToInt32(Console.ReadLine());
            if (Ly >= 11)
            {
                return;
            }
            Console.Write("Nhap diem mon Hoa: ");
            Hoa = Convert.ToInt32(Console.ReadLine());
            if (Hoa >= 11)
            {
                return;
            }
            // kiem tra trung tuyen

            int KetQua = Toan + Ly + Hoa;

            if (KetQua >= 20)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Thi sinh trung tuyen");
            } else
            {
                Console.WriteLine("\n");
                Console.WriteLine("Thi sinh khong trung tuyen");
            }

            






            Console.ReadKey();
        }
    }
}
