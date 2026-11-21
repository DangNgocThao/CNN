using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan8
{
    public class lop_khoa
    {
        string maLop, tenLop, maKhoa;

        public string MaLop
        {
            get { return maLop; }
            set { maLop = value; }
        }

        public string TenLop
        {
            get { return tenLop; }
            set { tenLop = value; }
        }

        public string MaKhoa
        {
            get { return maKhoa; }
            set { maKhoa = value; }
        }
        public lop_khoa(string maLop,string tenLop,string maKhoa)
        {
            this.maLop = maLop;
            this.tenLop = tenLop;
            this.maKhoa = maKhoa;
        }
    }
}
