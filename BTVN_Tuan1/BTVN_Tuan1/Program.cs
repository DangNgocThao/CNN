using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Tuan1
{
    public class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        static void menu()
        {
            int cn;
            do
            {
                Console.WriteLine("menu");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("1. Tinh f(x) 1a");
                Console.WriteLine("2. Tinh f(x) 1b");
                Console.WriteLine("3. Xuat cac so co 2 chu so doi mot khac nhau");
                Console.WriteLine("4. In ra tat ca cac so le nho hon n");
                Console.WriteLine("5. Dem so luong so chan trong [n, m]");
                try
                {
                    Console.Write("Chon chuc nang: ");
                    cn=Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Du lieu khong hop le!");
                    return;
                }
                switch (cn)
                {
                    case 1:
                        tinh1a();
                        break;
                    case 2:
                        tinh1b();
                        break;
                    case 3:
                        xuat2ChuSoKhacNhau();
                        break;
                    case 4:
                        xuatSoLe();
                        break;
                    case 5:
                        demSoChan();
                        break;
                    default:
                        break;
                }
            } while (cn!=0);
        }
        static void tinh1a()
        {
            double x, f;
            try
            {
                Console.Write("Nhap x: ");
                x = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {

                Console.WriteLine("Du lieu khong hop le!");
                return;
            }
            if (x > 0)
                f = 3 * x + Math.Sqrt(x);
            else
                f = Math.Pow(Math.E, x) + 4;
            Console.WriteLine("f({0}) = {1}", x, f);
        }
        static void tinh1b()
        {
            double x, f;
            try
            {
                Console.Write("Nhap x: ");
                x = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {

                Console.WriteLine("Du lieu khong hop le!");
                return;
            }
            if (x >= 1)
                f = Math.Sqrt(Math.Pow(x, 2) + 1);
            else if (x > -1)
                f = 3 * x + 5;
            else
                f = Math.Pow(x, 2) + 2 * x - 1;
            Console.WriteLine("f({0}) = {1}", x, f);
        }
        static void xuat2ChuSoKhacNhau()
        {
            int t = 0;
            Console.Write("Danh sach cac so co 2 chu so doi mot khac nhau la: ");
            for (int i = 10; i < 100; i++)
            {
                if (i % 10 != i / 10)
                {
                    if (t == 0)
                        t = 1;
                    else
                        Console.Write(", ");
                    Console.Write(i);
                }
            }
            Console.WriteLine();
        }
        static void xuatSoLe()
        {
            int n;
            try
            {
                do
                {
                    Console.Write("Nhap n: ");
                    n = Convert.ToInt32(Console.ReadLine());
                } while (n <= 0);
            }
            catch
            {

                Console.WriteLine("Du lieu khong hop le!");
                return;
            }
            Console.Write("Cac so le < {0}:   ", n);
            for (int i = 1; i < n; i++)
            {
                if (i % 2 != 0)
                    Console.Write("{0}   ", i);
            }
            Console.WriteLine();
        }
        static void demSoChan()
        {
            int n, m, d = 0;
            try
            {
                do
                {
                    Console.Write("Nhap n: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nhap m: ");
                    m = Convert.ToInt32(Console.ReadLine());
                } while (n >= m);
            }
            catch
            {

                Console.WriteLine("Du lieu khong hop le!");
                return;
            }
            for (int i = n; i <= m; i++)
            {
                if (i % 2 == 0)
                    d++;
            }
            Console.WriteLine("co {0} so chan trong [{1}, {2}]", d, n, m);
        }
    }
}
