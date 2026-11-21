using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan8
{
    public class Lop : CSDL
    {
        public int ktTrung(string pMaLop)
        {
            return base.ktTrung("select count(*) from Lop where MaLop = '" + pMaLop + "'");
        }
        public bool them(string ma, string ten, string maKhoa)
        {
            return chucNang("insert into Lop values('" + ma + "',N'" + ten + "','" + maKhoa + "')");
        }
        public bool xoa(string ma)
        {
            return chucNang("delete from Lop where MaLop = '" + ma + "'");
        }
        public bool sua(string ma, string ten, string maKhoa)
        {
            if (maKhoa == string.Empty)
                return chucNang("update Lop set TenLop = N'" + ten + "'where MaLop = '" + ma + "'");
            else if (ten == string.Empty)
                return chucNang("update Lop set MaKhoa = '" + maKhoa + "'where MaLop = '" + ma + "'");
            else
                return chucNang("update Lop set TenLop = N'" + ten + "', MaKhoa = '" + maKhoa + "'where MaLop = '" + ma + "'");
        }
        public List<string> LoadMaKhoa()
        {
            return LayDL("select MaKhoa from Khoa");
        }
        public List<string> LoadMaLop()
        {
            return LayDL("select MaLop from Lop");
        }
    }
}