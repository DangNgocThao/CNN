using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan7
{
    public class Khoa : CSDL
    {
        public bool them(string ma, string ten)
        {
            return chucNang("insert into Khoa values('" + ma + "','" + ten + "')");
        }
        public bool xoa(string ma)
        {
            return chucNang("delete from Khoa where MaKhoa = '" + ma + "'");
        }
        public bool sua(string ma, string ten)
        {
            return chucNang("update Khoa set TenKhoa = '" + ten + "'where MaKhoa = '" + ma + "'");
        }
    }
}
