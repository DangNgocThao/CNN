using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiMau
{
    public class Mang1C
    {
        public int[] a = new int[0];
        public void Nhap(int n)
        {
            Array.Resize(ref a, a.Length + 1);
            a[a.Length - 1] = n;
        }
        public string Xuat()
        {
            string s = a[0].ToString();
            for (int i = 1; i < a.Length; i++)
            {
                s += " " + a[i].ToString();
            }
            return s;
        }
        public void Clear()
        {
            Array.Clear(a, 0, a.Length);
            Array.Resize(ref a, 0);
        }
        public int Tong()
        {
            return a.Sum();
        }
        public int TongChan()
        {
            return a.Where(t => t % 2 == 0).Sum();
        }
        public int TongLe()
        {
            return a.Where(t => t % 2 == 1).Sum();
        }
    }
}
