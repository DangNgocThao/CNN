using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiMau
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

        public TinhToan(double a, double b)
        {
            this.A = a;
            this.B = b;
        }

        public double tinhTong()
        {
            return a + b;
        }
        public double tinhHieu()
        {
            return a - b;
        }
        public double tinhTich()
        {
            return a * b;
        }
        public double tinhThuong()
        {
            return a / b;
        }
    }
}
