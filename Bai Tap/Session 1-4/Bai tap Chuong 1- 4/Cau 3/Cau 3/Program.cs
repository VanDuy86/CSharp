using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.	Đăng ký tài khoản gồm username và password. Sau đó đăng nhập, nếu quá 3 lần không đúng thì hiển thị thông báo
            //Dang ky tai khoan
            string usename, password, usename_login, password_login, password_check;
            Console.WriteLine("****Dang ky tai khoan****");
            Console.Write("Nhap ten dang nhap: ");
            usename = Console.ReadLine();
            Console.Write("Nhap mat khau: ");
            password = Console.ReadLine();

            // Kiem tra mat khau
            do
            {
                Console.Write("Nhap lai mat khau: ");
                password_check = Console.ReadLine();
            } while (password != password_check);

            // Dang Nhap tai khoan
            Console.WriteLine("****Dang nhap tai khoan****");
            Console.Write("Ten dang nhap: ");
            usename_login = Console.ReadLine();
            Console.Write("Mat khau: ");
            password_login = Console.ReadLine();

            // Cach 3 Kiem tra tai khoan
            int count = 0;
            if (usename != usename_login || password != password_login)
            {
                do
                {
                    Console.WriteLine("Sai ten dang nhap hoac mat khau ");
                    Console.WriteLine("Dang Nhap: ");
                    Console.Write("Ten dang nhap: ");
                    usename_login = Console.ReadLine();
                    Console.Write("Mat khau: ");
                    password_login = Console.ReadLine();

                    count++;
                }
                while ((usename != usename_login || password != password_login) && (count != 2));

            }
            if (count == 2)
            {
                Console.WriteLine("Nhap sai 3 lan tai khoan bi khoa ");
            }
            else
            {
                Console.WriteLine("Dang nhap thanh cong");
            }

            //Cach 1 Kiem tra tai khoan

            /*if (usename != usename_login || password != password_login)
            {
                Console.WriteLine("Sai ten dang nhap hoac mat khau lan 1 . Vui long nhap lai. Nhap sai 3 lan khoa tai khoan");

                if (usename != usename_login || password != password_login)
                {
                    Console.Write("Ten dang nhap: ");
                    usename_login = Console.ReadLine();
                    Console.Write("Mat khau: ");
                    password_login = Console.ReadLine();
                    if (usename != usename_login || password != password_login)
                    {
                        Console.WriteLine("Sai ten dang nhap hoac mat khau lan 2 . Vui long nhap lai. Nhap sai 3 lan khoa tai khoan");
                    }
                    
                    if (usename != usename_login || password != password_login)
                    {
                        Console.Write("Ten dang nhap: ");
                        usename_login = Console.ReadLine();
                        Console.Write("Mat khau: ");
                        password_login = Console.ReadLine();
                        if (usename != usename_login || password != password_login)
                        {
                            Console.WriteLine("Sai ten dang nhap hoac mat khau lan 3 . Tai khoan bi khoa");
                        }
                        else
                        {
                            Console.WriteLine("Dang nhap thanh cong");
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine ( "Dang nhap thanh cong");
                    }
                }
                else
                {
                    Console.WriteLine ( "Dang nhap thanh cong");
                }
            }
            else
            {
                Console.WriteLine ( "Dang nhap thanh cong");
            }
            */

            // Cach 2 kiem tra tai khoan

            /* if (usename == usename_login && password == password_login)
            {
                Console.WriteLine("Dang nhap thanh cong");
            }
            else
            {
                Console.WriteLine("Sai ten dang nhap hoac mat khau lan 1 . Vui long nhap lai. Nhap sai 3 lan khoa tai khoan");
                Console.Write("Ten dang nhap: ");
                usename_login = Console.ReadLine();
                Console.Write("Mat khau: ");
                password_login = Console.ReadLine();
                if (usename == usename_login && password == password_login)
                {
                    Console.WriteLine("Dang nhap thanh cong");
                }
                else
                {
                    Console.WriteLine("Sai ten dang nhap hoac mat khau lan 2 . Vui long nhap lai. Nhap sai 3 lan khoa tai khoan");
                    Console.Write("Ten dang nhap: ");
                    usename_login = Console.ReadLine();
                    Console.Write("Mat khau: ");
                    password_login = Console.ReadLine();
                    if (usename == usename_login && password == password_login)
                    {
                        Console.WriteLine("Dang nhap thanh cong");
                    }
                    else
                    {
                        Console.WriteLine("Sai ten dang nhap hoac mat khau lan 3 . Tai khoan bi khoa");
                    }
                }
            } */

            
            Console.ReadKey();
        }
    }
}
