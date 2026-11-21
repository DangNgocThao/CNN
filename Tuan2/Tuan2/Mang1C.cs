using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan2
{
    public class Mang1C
    {
        public int[] A;
        public void NhapMang(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Moi nhap phan tu A[{0}]=", i);
                A[i] = int.Parse(Console.ReadLine());
            }
        }
        public void XuatMang()
        {
            Console.Write("Mang: ");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("\t {0}", A[i]);
            }
            Console.WriteLine();
        }
        public void Mang1Chieu()
        {
            Console.Write("Moi ban nhap vao so phan tu: ");
            int n;
            try
            {
                do
                {
                    n = int.Parse(Console.ReadLine());
                } while (n < 1);
            }
            catch
            {
                Console.WriteLine("Nhap sai");
                return;
            }
            A = new int[n];
            NhapMang(n);
            XuatMang();
        }
        public void XuatPTLeOViTriChan()
        {
            int kt = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (i % 2 == 0 && A[i] % 2 != 0)
                {
                    if (kt == 0)
                    {
                        kt = 1;
                        Console.Write("Cac phan tu le o vi tri chan trong mang: ");
                    }
                    Console.Write("\t {0}", A[i]);
                }
            }
            if (kt == 0)
                Console.Write("Khong co phan tu le o vi tri chan trong mang");
            Console.WriteLine();
        }
        public bool ktSNT(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        public void XuatSNT()
        {
            int kt = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (ktSNT(A[i]) == true)
                {
                    if (kt == 0)
                    {
                        kt = 1;
                        Console.Write("Cac so nguyen to trong mang: ");
                    }
                    Console.Write("\t {0}", A[i]);
                }
            }
            if (kt == 0)
                Console.Write("Khong co so nguyen to trong mang");
            Console.WriteLine();
        }
        public void XuatSoAmDau()
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < 0)
                {
                    Console.WriteLine("So am dau tien trong mang: {0}", A[i]);
                    return;
                }
            }
            Console.WriteLine("Khong co so am trong mang");
        }
        public void timMaxMin()
        {
            Console.WriteLine("Max: {0}", A.Max());
            Console.WriteLine("Min: {0}", A.Min());
        }
        public void TongMang()
        {
            Console.WriteLine("Tong mang: {0}", A.Sum());
        }
    }
}
