using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Tuan2
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
            Console.Read();
        }
        static void menu()
        {
            int cn;
            Mang1C a = new Mang1C();
            Mang2C b = new Mang2C();
            do
            {
                Console.WriteLine("menu");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("1. Nhap mang 1 chieu");
                Console.WriteLine("2. Tong cac phan tu cuc dai trong mang");
                Console.WriteLine("3. Nhap ma tran vuong");
                Console.WriteLine("4. Liet ke cheo chinh, phu");
                Console.WriteLine("5. Liet ke tam giac tren, duoi");
                Console.WriteLine("6. Tong duong cheo chinh, phu");
                Console.WriteLine("7. Tong tam giac tren, duoi");
                try
                {
                    Console.Write("Chon chuc nang: ");
                    cn = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Du lieu khong hop le!");
                    return;
                }
                switch (cn)
                {
                    case 1:
                        a.Mang1Chieu();
                        break;
                    case 2:
                        a.TongCucDai();
                        break;
                    case 3:
                        b.Mang2Chieu();
                        break;
                    case 4:
                        b.XuatCC();
                        b.XuatCP();
                        break;
                    case 5:
                        b.XuatTGT();
                        b.XuatTGD();
                        break;
                    case 6:
                        b.TongCC();
                        b.TongCP();
                        break;
                    case 7:
                        b.TongTGT();
                        b.TongTGD();
                        break;
                    default:
                        break;
                }
            } while (cn != 0);
        }
    }
}
