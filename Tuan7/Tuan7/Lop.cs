using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan7
{
    public class Lop : CSDL
    {
        public bool them(string ma, string ten, string maKhoa)
        {
            return chucNang("insert into Lop values('" + ma + "','" + ten + "','" + maKhoa + "')");
        }
        public bool xoa(string ma)
        {
            return chucNang("delete from Lop where MaLop = '" + ma + "'");
        }
        public bool sua(string ma, string ten, string maKhoa)
        {
            if (maKhoa == string.Empty)
                return chucNang("update Lop set TenLop = '" + ten + "'where MaLop = '" + ma + "'");
            else if (ten == string.Empty)
                return chucNang("update Lop set MaKhoa = '" + maKhoa + "'where MaLop = '" + ma + "'");
            else
                return chucNang("update Lop set TenLop = '" + ten + "', MaKhoa = '" + maKhoa + "'where MaLop = '" + ma + "'");
        }
    }
}