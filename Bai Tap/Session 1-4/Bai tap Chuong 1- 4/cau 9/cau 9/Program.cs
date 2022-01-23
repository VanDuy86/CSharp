using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cau_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Nhap so A va B tu nguoi dung
            float SoA, SoB;
            Console.Write("Nhập Số A: ");
            SoA = float.Parse(Console.ReadLine());
            Console.Write("Nhập Số B: ");
            SoB = float.Parse(Console.ReadLine());

            //Chon phep toan

            Console.WriteLine("Chon phep toan");
            Console.WriteLine("1 Phep cong (Nhan so 1 de chon)");
            Console.WriteLine("2 Phep tru (Nhan so 2 de chon)");
            Console.WriteLine("3 Phep Nhan (Nhan so 3 de chon)");
            Console.WriteLine("4 Phep Chia (Nhan so 4 de chon)");
            Console.WriteLine("5 Thoat (Nhan so 5 de thoat)");
            // Thuc hien tinh toan ( + - * / )

            int KetQua = Convert.ToInt32(Console.ReadLine());
            if (KetQua == 1)
            {
                Console.WriteLine("Ket Qua A+B = " + (SoA + SoB));
                Console.WriteLine("Bam phim bat ki de thoat");
            }
            if (KetQua == 2)
            {
                Console.WriteLine("Ket Qua A-B = " + (SoA - SoB));
                Console.WriteLine("Bam phim bat ki de thoat");
            }
            if (KetQua == 3)
            {
                Console.WriteLine("Ket Qua A*B = " + (SoA * SoB));
                Console.WriteLine("Bam phim bat ki de thoat");
            }
            if (KetQua == 4)
            {
                Console.WriteLine("Ket Qua A/B = " + (SoA / SoB));
                Console.WriteLine("Bam phim bat ki de thoat");
            }
            if (KetQua == 5)
            {
                return;
            }
            if (KetQua > 5)
            {
                Console.WriteLine("Nhap so tu 1 den 5");
                Console.WriteLine("Bam phim bat ki de thoat");
            }


            /* switch (KetQua)
              {
                  case 1:
                      Console.WriteLine("Ket Qua A+B = " + (SoA + SoB));
                      Console.WriteLine("Bam phim bat ki de thoat");
                      break;
                  case 2:
                      Console.WriteLine("Ket Qua A-B = " + (SoA - SoB));
                      Console.WriteLine("Bam phim bat ki de thoat");
                      break;
                  case 3:
                      Console.WriteLine("Ket Qua A*B = " + (SoA * SoB));
                      Console.WriteLine("Bam phim bat ki de thoat");
                      break;
                  case 4:
                      Console.WriteLine("Ket Qua A/B = " + (SoA / SoB));
                      Console.WriteLine("Bam phim bat ki de thoat");
                      break;
                case 5:
                    return;

                default:
                      Console.WriteLine("Nhap so tu 1 den 5");
                      break;
              } */

            Console.ReadKey();
        }
    }
}
