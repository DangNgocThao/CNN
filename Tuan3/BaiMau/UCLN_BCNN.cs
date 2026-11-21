using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiMau
{
    public class UCLN_BCNN
    {
        int a, b;

        public int A
        {
            get { return a; }
            set { a = value; }
        }

        public int B
        {
            get { return b; }
            set { b = value; }
        }
        public UCLN_BCNN()
        {
            a = b = 0;
        }
        public UCLN_BCNN(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int UCLN()
        {
            int max = Math.Max(a, b);
            for (int i = max - 1; i > 0; i--)
                if (a % i == 0 && b % i == 0)
                    return i;
            return 0;
        }
        public int BCNN()
        {
            return a * b / UCLN();
        }
    }
}
