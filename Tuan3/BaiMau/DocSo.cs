using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiMau
{
    public class DocSo
    {
        public string don_vi(int n, int l)
        {
            switch (n)
            {
                case 0:
                    if (l == 1)
                        return "Không";
                    else
                        return "";
                case 1:
                    return "Một";
                case 2:
                    return "Hai";
                case 3:
                    return "Ba";
                case 4:
                    return "Bốn";
                case 5:
                    if (l == 1)
                        return "Năm";
                    else
                        return "Lăm";
                case 6:
                    return "Sáu";
                case 7:
                    return "Bảy";
                case 8:
                    return "Tám";
                default:
                    return "Chín";
            }
        }
        public string hang_chuc(int n)
        {
            switch (n)
            {
                case 0:
                    return "linh";
                case 1:
                    return "Mười";
                case 2:
                    return "Hai Mươi";
                case 3:
                    return "Ba Mươi";
                case 4:
                    return "Bốn Mươi";
                case 5:
                    return "Năm Mươi";
                case 6:
                    return "Sáu Mươi";
                case 7:
                    return "Bảy Mươi";
                case 8:
                    return "Tám Mươi";
                default:
                    return "Chín Mươi";
            }
        }
        public string hang_tram(int n)
        {
            switch (n)
            {
                case 0:
                    return "Không Trăm";
                case 1:
                    return "Một Trăm";
                case 2:
                    return "Hai Trăm";
                case 3:
                    return "Ba Trăm";
                case 4:
                    return "Bốn Trăm";
                case 5:
                    return "Năm Trăm";
                case 6:
                    return "Sáu Trăm";
                case 7:
                    return "Bảy Trăm";
                case 8:
                    return "Tám Trăm";
                default:
                    return "Chín Trăm";
            }
        }
        public string SoSangChu(string s)
        {
            int l = s.Length;
            if (l == 1)
            {
                return don_vi(int.Parse(s), l);
            }
            else if (l == 2)
            {
                string s1, s2;
                s1 = don_vi(int.Parse(s.Substring(s.Length - 1, 1)), l);
                s2 = hang_chuc(int.Parse(s.Substring(s.Length - 2, 1)));
                return s2 + " " + s1;
            }
            else
            {
                string s1, s2, s3;
                s1 = don_vi(int.Parse(s.Substring(s.Length - 1, 1)), l);
                s2 = hang_chuc(int.Parse(s.Substring(s.Length - 2, 1)));
                s3 = hang_tram(int.Parse(s.Substring(s.Length - 3, 1)));
                return s3 + " " + s2 + " " + s1;
            }
        }
    }
}
