using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Tuan2
{
    public class Mang2C
    {
        int[][] A;
        public void NhapMang(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
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
                for (int j = 0; j < A.Length; j++)
                {
                    Console.Write("{0}\t", A[i][j]);
                }
                Console.WriteLine();
            }
        }
        public void Mang2Chieu()
        {
            int n;
            try
            {
                do
                {
                    Console.Write("Moi ban nhap so cap: ");
                    n = int.Parse(Console.ReadLine());
                } while (n < 1 || n < 1);
            }
            catch
            {
                Console.WriteLine("Nhap sai");
                return;
            }
            A = new int[n][];
            for (int i = 0; i < n; i++)
            {
                A[i] = new int[n];
            }
            NhapMang(n);
            XuatMang();
        }
        public void XuatCC()
        {
            Console.Write("Cac phan tu tren duong cheo chinh: ");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("{0}\t", A[i][i]);
            }
            Console.WriteLine();
        }
        public void XuatCP()
        {
            Console.Write("Cac phan tu tren duong cheo phu: ");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("{0}\t", A[i][A.Length - 1 - i]);
            }
            Console.WriteLine();
        }
        public void XuatTGT()
        {
            Console.Write("Cac phan tu trong tam giac tren: ");
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    if (i < j)
                        Console.Write("{0}\t", A[i][j]);
                }
            }
            Console.WriteLine();
        }
        public void XuatTGD()
        {
            Console.Write("Cac phan tu trong tam giac duoi: ");
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    if (i > j)
                        Console.Write("{0}\t", A[i][j]);
                }
            }
            Console.WriteLine();
        }
        public void TongCC()
        {
            int tong = 0;
            for (int i = 0; i < A.Length; i++)
            {
                tong += A[i][i];
            }
            Console.WriteLine("Tong cac phan tu tren duong cheo chinh: {0}", tong);
        }
        public void TongCP()
        {
            int tong = 0;
            for (int i = 0; i < A.Length; i++)
            {
                tong += A[i][A.Length - 1 - i];
            }
            Console.WriteLine("Tong cac phan tu tren duong cheo phu: {0}", tong);
        }
        public void TongTGT()
        {
            int tong = 0;
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    if (i < j)
                        tong += A[i][j];
                }
            }
            Console.WriteLine("Tong cac phan tu trong tam giac tren: {0}", tong);
        }
        public void TongTGD()
        {
            int tong = 0;
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    if (i > j)
                        tong += A[i][j];
                }
            }
            Console.WriteLine("Tong cac phan tu trong tam giac duoi: {0}", tong);
        }
    }
}
