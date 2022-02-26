using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau_2
{
    class Phanso
    {
        public int tuso { get; set; }
        public int mauso { get; set; }

        public Phanso() { }
        ~Phanso() { }

        public void NhapPhanSo()
        {
            Console.Write("Nhap tu so: ");
            this.tuso = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("Nhap mau so > 0: ");
                this.mauso = int.Parse(Console.ReadLine());
            } while (this.mauso <= 0);
            
        }
        public void InPhanSo()
        {
            Console.Write($"{tuso}/{mauso}");
        }
        public Phanso Tong(Phanso obj1, Phanso obj2)
        {
            Phanso KQ = new Phanso();
            KQ.tuso = (obj1.tuso * obj2.mauso) + (obj2.tuso * obj1.mauso);
            KQ.mauso = obj1.mauso * obj2.mauso;
            return KQ;
            
        }
        public Phanso Hieu(Phanso obj1, Phanso obj2)
        {
            Phanso KQ = new Phanso();
            KQ.tuso = (obj1.tuso * obj2.mauso) - (obj2.tuso * obj1.mauso); ;
            KQ.mauso = obj1.mauso * obj2.mauso;
            return KQ;

        }
        public Phanso Tich(Phanso obj1, Phanso obj2)
        {
            Phanso KQ = new Phanso();
            KQ.tuso = obj1.tuso * obj2.tuso;
            KQ.mauso = obj1.mauso * obj1.mauso;
            return KQ;

        }
        public Phanso Thuong(Phanso obj1, Phanso obj2)
        {
            Phanso KQ = new Phanso();
            KQ.tuso = obj1.tuso *obj2.mauso ;
            KQ.mauso = obj1.mauso * obj2.tuso;
            return KQ;

        }

    }
    
           
    

}
