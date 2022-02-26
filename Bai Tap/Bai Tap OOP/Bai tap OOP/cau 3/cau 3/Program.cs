using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cau_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong sach : ");
            int soluong = int.Parse(Console.ReadLine());

            BookList Books = new BookList(soluong);
            Console.WriteLine("==================================");
            Books.Themsach(soluong);

            do
            {
                Console.WriteLine("1. In Sach");
                Console.WriteLine("2. Sap xep theo ten sach");
                Console.WriteLine("3. Xoa Sach");
                Console.WriteLine("==================================");
                Console.Write("Nhap tuy chon: ");
                int chon = int.Parse(Console.ReadLine());
                Console.WriteLine("==================================");
                if (chon == 1)
                {
                    Books.Insach();
                }
                if (chon == 2)
                {
                    Books.SapxepTheoTenSach();
                }
                if (chon == 3)
                {
                    Books.Xoasach();
                }

            } while (true);

           

            
            
        }
    }
}
