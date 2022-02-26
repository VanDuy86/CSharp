using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cau_3
{
    ////tên sách, tên tác giả, nhà xuất bản, năm xuất bản, số hiệu ISBN
    class BookList : Book
    {
        BookList[] Books;

       public BookList() {}
       public BookList (int soluong)
        {
            Books = new BookList[soluong];
        }
        
        public void Themsach(int soluong)
        {
            
            for (int i = 0; i < soluong; i++)
            {
                BookList them = new BookList();

                Console.Write($"Nhap ID sach thu [{i +1}]: ");
                them.Idsach = Console.ReadLine();

                Console.Write($"Nhap ten sach thu [{i + 1}]: ");
                them.Tensach = Console.ReadLine();

                Console.Write($"Nhap ten chuong sach (Ten chuong 1, Ten chuong2,....): ");
                them.Tenchuong = Console.ReadLine();

                Console.Write($"Nhap ten tac gia: ");
                them.Tentacgia = Console.ReadLine();

                Console.Write($"Nhap ten nha xuat ban: ");
                them.Nhaxuatban = Console.ReadLine();

                Console.Write($"Nhap nam san xuat: ");
                them.Namxuatban = int.Parse(Console.ReadLine());
                Console.WriteLine("==================================");
                Books[i] = them;
                
            }
        }
        public void Insach()
        {
            
           foreach (BookList item in Books)
            {
                item.InThongTinSach();
                Console.WriteLine("==================================");
            }
           
            
        }
        public void Capnhat ()
        {
            Console.Write("Nhap ID sach: ");
            string x = Console.ReadLine();

            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Idsach == x)
                {
                    Console.Write($"Nhap ten sach: ");
                    Books[i].Tensach = Console.ReadLine();

                    Console.Write($"Nhap ten chuong sach(Ten chuong 1, Ten chuong2, ....): ");
                    Books[i].Tenchuong = Console.ReadLine();

                    Console.Write($"Nhap ten tac gia: ");
                    Books[i].Tentacgia = Console.ReadLine();

                    Console.Write($"Nhap ten nha xuat ban: ");
                    Books[i].Nhaxuatban = Console.ReadLine();

                    Console.Write($"Nhap nam san xuat: ");
                    Books[i].Namxuatban = int.Parse (Console.ReadLine());

                    Console.WriteLine("==================================");
                }
            }
                    
        }
       
        public void Xoasach ()
        {
            Console.Write($"Nhap ID sach can xoa: ");
            string x = Console.ReadLine();
            int dem = 0;

            BookList[] books2 = (BookList[])Books.Clone();
            Books = new BookList[Books.Length -1];

            for (int i = 0; i < books2.Length; i++)
            {
                if(books2[i].Idsach != x)
                {
                    Books[dem] = books2[i];
                    dem++;
                }
            }
            
            Console.WriteLine("==================================");

        }

        private class SapXepTheoTenSach : IComparer
        {
            public int Compare(object x, object y)
            {
                var Sapxep = new CaseInsensitiveComparer();
                return Sapxep.Compare( ((BookList)x).Tensach, ((BookList)y).Tensach );
            }
        }

        public void SapxepTheoTenSach()
        {
            Array.Sort(Books, new SapXepTheoTenSach());

        }
       
    }
}
