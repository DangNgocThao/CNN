using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan4
{
    public class PhuongTrinh
    {
        double a, b, c;

        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public double B
        {
            get { return b; }
            set { b = value; }
        }

        public double C
        {
            get { return c; }
            set { c = value; }
        }
        public PhuongTrinh(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public string GiaiPTBacNhat()
        {
            string s;
            if (a == 0)
            {
                if (b == 0)
                    return s = "Phuong trinh vo so nghiem";
                else
                    return s = "Phuong trinh vo nghiem";
            }
            double kq = -b / a;
            return s = "Phuong trinh co nghiem x = " + kq;
        }
        public string GiaiPTBacHai()
        {
            string s;
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        return s = "Phuong trinh vo so nghiem";
                    else
                        return s = "Phuong trinh vo nghiem";
                }
                double kq = -c / b;
                return s = "Phuong trinh co nghiem x = " + kq;
            }
            double delta = (b * b) - (4 * a * c);
            if (delta < 0)
                return s = "Phuong trinh vo nghiem";
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                return s = "Phuong trinh co nghiem kep x1 = x2 = " + x;
            }
            else
            {
                double x1, x2;
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return s = "Phuong trinh co 2 nghiem phan biet x1 = " + x1 + ", x2 = " + x2;
            }
        }
    }
}
