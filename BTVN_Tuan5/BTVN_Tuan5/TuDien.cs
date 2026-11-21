using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Tuan5
{
    public class TuDien
    {
        string anh, viet;

        public string Anh { get => anh; set => anh = value; }
        public string Viet { get => viet; set => viet = value; }

        public TuDien( string anh, string viet)
        {
            this.anh = anh;
            this.viet = viet;
        }
    }
}
