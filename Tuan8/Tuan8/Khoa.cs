using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan8
{
    public class Khoa : CSDL
    {
        public int ktTrung(string pMaKhoa)
        {
            return base.ktTrung("select count(*) from Khoa where MaKhoa = '" + pMaKhoa + "'");
        }
        public bool them(string ma, string ten)
        {
            return chucNang("insert into Khoa values('" + ma + "',N'" + ten + "')");
        }
        public bool xoa(string ma)
        {
            return chucNang("delete from Khoa where MaKhoa = '" + ma + "'");
        }
        public bool sua(string ma, string ten)
        {
            return chucNang("update Khoa set TenKhoa = N'" + ten + "'where MaKhoa = '" + ma + "'");
        }
        public List<string> LoadMaKhoa()
        {
            return LayDL("select MaKhoa from Khoa");
        }
    }
}
