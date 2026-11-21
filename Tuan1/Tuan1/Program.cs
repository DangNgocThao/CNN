using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan1
{
    class Program
    {
        static void Main(string[] args)
        {
            //tinhTien();
            //tienDien();
            //xuatBCCDoc();
            //xuatBCCNgang();
            //veHCN();
            //veHCNRong();
            //tinhTong();
            //xuatKtSNT();
            //xuatDaySNT();
            daySoNguyen();
            Console.Read();
        }
        static double tinhThanhTien(double dongia, int solg)
        {
            return dongia * solg;
        }
        static double tinhGiamgia(double dongia, int solg)
        {
            double t = tinhThanhTien(dongia, solg);
            if (t > 100)
                return t * 0.03;
            return 0;
        }
        static double tongTien(double dongia, int solg)
        {
            return tinhThanhTien(dongia, solg) - tinhGiamgia(dongia, solg);
        }
        static void tinhTien()
        {
            double dongia;
            int solg;
            try
            {
                do
                {
                    Console.Write("Nhap don gia: ");
                    dongia = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Nhap so luong: ");
                    solg = Convert.ToInt32(Console.ReadLine());
                } while (dongia < 0 || solg < 0);
            }
            catch
            {

                Console.WriteLine("Du lieu khong hop le!");
                return;
            }
            Console.WriteLine("Tong tien phai tra: {0}", tongTien(dongia, solg));
        }

        static double tinhTienDien(int solg)
        {
            if (solg <= 100)
                return solg * 5;
            else if (solg <= 150)
                return 100 * 5 + (solg - 100) * 7;
            else if (solg <= 200)
                return 100 * 5 + 50 * 7 + (solg - 150) * 10;
            else if (solg <= 300)
                return 100 * 5 + 50 * 7 + 50 * 10 + (solg - 200) * 15;
            else
                return 100 * 5 + 50 * 7 + 50 * 10 + 100 * 15 + (solg - 300) * 20;
        }
        static void tienDien()
        {
            int solg;
            try
            {
                do
                {
                    Console.Write("Nhap so dien tieu thu: ");
                    solg = Convert.ToInt32(Console.ReadLine());
                } while (solg < 0);
            }
            catch
            {

                Console.WriteLine("Du lieu khong hop le!");
                return;
            }
            Console.WriteLine("Tong tien phai tra: {0}", tinhTienDien(solg));
        }
        static void xuatBCCDoc()
        {
            int n;
            try
            {
                Console.Write("Nhap n: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {

                Console.WriteLine("Du lieu khong hop le!");
                return;
            }
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0}*{1}={2}", i, j, i * j);
                }
                Console.WriteLine();
            }
        }
        static void xuatBCCNgang()
        {
            int n;
            try
            {
                Console.Write("Nhap n: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {

                Console.WriteLine("Du lieu khong hop le!");
                return;
            }
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("{0}*{1}={2}\t", i, j, i * j);
                }
                Console.WriteLine();
            }
        }
        static void veHCN()
        {
            int d, r;
            try
            {
                do
                {
                    Console.Write("Nhap chieu dai: ");
                    d = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nhap chieu rong: ");
                    r = Convert.ToInt32(Console.ReadLine());
                } while (d < 0 || r < 0 || d < r);
            }
            catch
            {

                Console.WriteLine("Du lieu khong hop le!");
                return;
            }
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    Console.Write("*\t");
                }
                Console.WriteLine();
            }
        }
        static void veHCNRong()
        {
            int d, r;
            try
            {
                do
                {
                    Console.Write("Nhap chieu dai: ");
                    d = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nhap chieu rong: ");
                    r = Convert.ToInt32(Console.ReadLine());
                } while (d < 0 || r < 0 || d < r);
            }
            catch
            {

                Console.WriteLine("Du lieu khong hop le!");
                return;
            }
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    if (i == 0 || j == 0 || i == r - 1 || j == d - 1)
                        Console.Write("*\t");
                    else
                        Console.Write("\t");
                }
                Console.WriteLine();
            }
        }
        static void tinhTong()
        {
            int n;
            try
            {
                do
                {
                    Console.Write("Nhap n: ");
                    n = Convert.ToInt32(Console.ReadLine());
                } while (n < 1);
            }
            catch
            {

                Console.WriteLine("Du lieu khong hop le!");
                return;
            }
            double tong = 0;
            for (int i = 1; i <= n; i++)
            {
                tong += (i * i);
            }
            Console.WriteLine("n = {0}: S = {1}", n, tong);
        }
        static bool ktSNT(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        static void xuatKtSNT()
        {
            int n;
            try
            {
                do
                {
                    Console.Write("Nhap n: ");
                    n = Convert.ToInt32(Console.ReadLine());
                } while (n < 0);
            }
            catch
            {

                Console.WriteLine("Du lieu khong hop le!");
                return;
            }
            if (ktSNT(n))
                Console.WriteLine("{0} la so nguyen to", n);
            else
                Console.WriteLine("{0} khong la so nguyen to", n);
        }
        static void xuatDaySNT()
        {
            int n;
            try
            {
                do
                {
                    Console.Write("Nhap n: ");
                    n = Convert.ToInt32(Console.ReadLine());
                } while (n < 0);
            }
            catch
            {

                Console.WriteLine("Du lieu khong hop le!");
                return;
            }
            Console.Write("Cac so nguyen to < {0}:   ", n);
            for (int i = 0; i < n; i++)
            {
                if (ktSNT(i))
                    Console.Write("{0}   ", i);
            }
        }
        static void daySoNguyen()
        {
            int n, tong = 0, max = Int32.MinValue, min = Int32.MaxValue;
            try
            {
                Console.WriteLine("Nhap day so:");
                do
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n == 0) break;
                    tong += n;
                    if (n > max) max = n;
                    if (n < min) min = n;
                } while (true);
            }
            catch
            {

                Console.WriteLine("Du lieu khong hop le!");
                return;
            }
            Console.WriteLine("Tong day = {0}", tong);
            Console.WriteLine("Max = {0}", max);
            Console.WriteLine("Min = {0}", min);
        }
    }
}
