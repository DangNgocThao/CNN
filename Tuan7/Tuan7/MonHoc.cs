using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan7
{
    public class MonHoc:CSDL
    {
        public bool them(string ma, string ten)
        {
            return chucNang("insert into MonHoc values('" + ma + "','" + ten + "')");
        }
        public bool xoa(string ma)
        {
            return chucNang("delete from MonHoc where MaMonHoc = '" + ma + "'");
        }
        public bool sua(string ma, string ten)
        {
            return chucNang("update MonHoc set TenMonHoc = '" + ten + "'where MaMonHoc = '" + ma + "'");
        }
    }
}
