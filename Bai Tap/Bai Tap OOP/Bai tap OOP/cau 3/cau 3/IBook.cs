using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cau_3
{
    //tên sách, tên tác giả, nhà xuất bản, năm xuất bản, số hiệu ISBN
    interface IBook
    {
        string Tensach { get; set; }
        string Tentacgia { get; set; }
        string Nhaxuatban { get; set; }
        int Namxuatban { get; set; }
        string Idsach { get; set; }
        string Tenchuong { get; set; }
        void InThongTinSach();
    }
}
