using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mang1C a = new Mang1C();
            //a.Mang1Chieu();
            //a.XuatPTLeOViTriChan();
            //a.XuatSNT();
            //a.XuatSoAmDau();
            //a.timMaxMin();
            //a.TongMang();
            Mang2C b = new Mang2C();
            b.Mang2Chieu();
            b.TongDuong();
            b.TongCC();
            b.TongTGT();
            b.tongChan();
            b.tongDongThuI();
            Console.Read();
        }
    }
}
