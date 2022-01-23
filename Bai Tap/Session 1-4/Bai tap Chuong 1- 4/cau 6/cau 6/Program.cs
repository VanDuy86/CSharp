using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cau_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6.	Giải phương trình bậc 1
            
            Console.Write("Nhap so a: ");
           float a = float.Parse (Console.ReadLine()) ;
            Console.Write("Nhap so b: ");
            float b = float.Parse (Console.ReadLine());

            if (a == 0 && b == 0)
            {
                
                Console.Write("phuong trinh vo so nghiem" );
            }
            if (a!= 0)
            {
                Console.Write("phuong trinh co nghiem la : ax + b = 0 ==> x = -b/a ==> x = " + (-b/a ));
            }
            if (a == 0 && b != 0)
            {
                Console.Write("phuong trinh vo nghiem");
            }

            Console.ReadKey();
        }
    }
}
