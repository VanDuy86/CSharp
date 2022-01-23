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
            //4.	Nhập tuổi của một người, kiểm tra xem người đó có đủ tuổi bầu cử không, và sau đó in thông báo tương ứng. (Độ tuổi bầu cử là >= 18)
            int age;
            Console.Write("Nhap tuoi cua ban: ");
            age = Convert.ToInt32 (Console.ReadLine()) ;
            if (age < 18)
            {
                Console.Write("Ban khong du tuoi bau cu. Tuoi bau cu la 18");
            }
            else
            {
                Console.Write("Ban du tuoi bau cu.");
            }

            Console.ReadKey();
        }
    }
}
