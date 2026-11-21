using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangNgocThao_2001206904_KT1
{
    public class Bai1
    {
        int n;

        public int N
        {
            get { return n; }
            set { n = value; }
        }
        public bool KTSNT(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        public string XuatSNT()
        {
            string s = string.Empty;
            int dem = 0;
            for (int i = 2; dem<n; i++)
            {
                if(KTSNT(i))
                {
                    s += i + " ";
                    dem++;
                }
            }
            return s;
        }
        public bool KTSCP(int n)
        {
            int t = (int)Math.Sqrt((double)n);
            if (n - (t * t) == 0)
                return true;
            else
                return false;
        }
        public int TongSCP()
        {
            int t=0;
            for (int i = 0; i < n; i++)
            {
                if (KTSCP(i))
                    t += i;
            }
            return t;
        }
    }
}
