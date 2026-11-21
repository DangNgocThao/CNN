using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Tuan2
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
        public void TongCucDai()
        {
            int tong = 0;
            if (A[0] > A[1]) tong += A[1];
            if (A[A.Length - 1] > A[A.Length - 2]) tong += A[A.Length - 1];
            for (int i = 1; i < A.Length - 1; i++)
            {
                if (A[i - 1] < A[i] && A[i + 1] < A[i])
                    tong += A[i];
            }
            Console.WriteLine("Tong cac phan tu cuc dai trong mang: {0}", tong);
        }
    }
}
