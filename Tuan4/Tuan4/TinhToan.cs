using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan4
{
    public class TinhToan
    {
        double a, b;
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public double A
        {
            get { return a; }
            set { a = value; }
        }
        public TinhToan() { A = B = 0; }
        public TinhToan(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public double Cong() { return a + b; }
        public double Tru() { return a - b; }
        public double Nhan() { return a * b; }
        public double Chia() { return a / b; }
    }
}
