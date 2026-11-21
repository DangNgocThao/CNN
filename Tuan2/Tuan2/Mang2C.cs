using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan2
{
    public class Mang2C
    {
        int[][] A;
        public void NhapMang(int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Nhap phan tu A[{0}][{1}]= ", i, j);
                    A[i][j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void XuatMang()
        {
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[i].Length; j++)
                {
                    Console.Write("{0}\t", A[i][j]);
                }
                Console.WriteLine();
            }
        }
        public void Mang2Chieu()
        {
            int n, m;
            try
            {
                do
                {
                    Console.Write("Moi ban nhap so dong: ");
                    n = int.Parse(Console.ReadLine());
                    Console.Write("Moi ban nhap so cot: ");
                    m = int.Parse(Console.ReadLine());
                } while (n < 1 || m < 1);
            }
            catch
            {
                Console.WriteLine("Nhap sai");
                return;
            }
            A = new int[n][];
            for (int i = 0; i < n; i++)
            {
                A[i] = new int[m];
            }
            NhapMang(n, m);
            XuatMang();
        }
        public void TongDuong()
        {
            int tong = 0;
            for (int i = 0; i < A.Length; i++)
            {
                tong += A[i].Where(t => t > 0).Sum();
            }
            Console.WriteLine("Tong cac phan tu duong trong ma tran: {0}", tong);
        }
        public void TongCC()
        {
            int tong = 0;
            if (A.Length != A[0].Length)
            {
                Console.WriteLine("Khong phai la ma tran vuong");
                return;
            }
            for (int i = 0; i < A.Length; i++)
            {
                tong += A[i][i];
            }
            Console.WriteLine("Tong cac phan tu tren duong cheo chinh: {0}", tong);
        }
        public void TongTGT()
        {
            int tong = 0;
            if (A.Length != A[0].Length)
            {
                Console.WriteLine("Khong phai la ma tran vuong");
                return;
            }
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[i].Length; j++)
                {
                    if (i < j)
                        tong += A[i][j];
                }
            }
            Console.WriteLine("Tong cac phan tu trong tam giac tren: {0}", tong);
        }
        public void tongChan()
        {
            int tong = 0, kt = 0;
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[i].Length; j++)
                {
                    if (A[i][j] % 2 == 0)
                    {
                        kt = 1;
                        tong += A[i][j];
                    }
                }
            }
            if (kt == 0)
                Console.WriteLine("Khong co chan trong ma tran");
        }
        public void tongDongThuI()
        {
            int i;
            try
            {
                do
                {
                    Console.Write("Moi ban nhap so dong: ");
                    i = int.Parse(Console.ReadLine());
                } while (i < 0 || i >= A.Length);
            }
            catch
            {
                Console.WriteLine("Nhap sai");
                return;
            }
            Console.WriteLine("Tong cac phan tu o dong thu {0}: {1}", i, A[i].Sum());
        }
    }
}
