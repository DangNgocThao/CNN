using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangNgocThao_2001206904_KT1
{
    public class Mang1Chieu
    {
        int[] a;

        public int[] A
        {
            get { return a; }
            set { a = value; }
        }
        public Mang1Chieu(int n)
        {
            a = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = r.Next(100);
            }
        }
        public string xuat()
        {
            string s = string.Empty;
            for (int i = 0; i < a.Length; i++)
            {
                s += a[i] + " ";
            }
            return s;
        }
        public bool ktSHH(int x)
        {
            int t = 0;
            for (int i = 1; i < x; i++)
            {
                if (x % i == 0)
                    t = t + i;
            }
            if (t == x)
                return true;
            else
                return false;
        }
        public string xuatSHH()
        {
            string s = string.Empty;
            for (int i = 0; i < a.Length; i++)
            {
                if (ktSHH(a[i]))
                    s += a[i] + " ";
            }
            if (s == string.Empty)
                s = "Không có số hoàn thiện trong mảng";
            return s;
        }
        public string xuatMaxChan()
        {
            int vt = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i]%2==0)
                {
                    vt = i;
                    break;
                }
            }
            if (vt == -1)
                return "Không có chẵn trong mảng";
            int max = a[vt];
            for (int i = vt; i < a.Length; i++)
            {
                if (max < a[i] && a[i] % 2 == 0)
                    max = a[i];
            }
            return max.ToString();
        }
    }
}
