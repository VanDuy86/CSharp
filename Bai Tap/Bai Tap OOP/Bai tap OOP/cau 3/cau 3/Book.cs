using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cau_3
{
    // tên sách, tên tác giả, nhà xuất bản, năm xuất bản, số hiệu ISBN
    class Book : IBook
    {
        public string Tensach { get ; set ; }
        public string Tentacgia { get ; set ; }
        public string Nhaxuatban { get ; set ; }
        public int Namxuatban { get ; set; }
        public string Idsach { get ; set ; }
        public string Tenchuong { get; set; }
        
        
        public void InThongTinSach()
        {
            Console.WriteLine($"ID sach: {Idsach}");
            Console.WriteLine($"Ten sach: {Tensach}");
            Console.WriteLine($"Ten chuong: {Tenchuong}");
            Console.WriteLine($"Ten tac gia: {Tentacgia}");
            Console.WriteLine($"Nha xuat ban: {Nhaxuatban}");
            Console.WriteLine($"Nam xuat ban: {Namxuatban}");
            
        }
    }
}
