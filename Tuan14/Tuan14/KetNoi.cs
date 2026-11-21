using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Tuan14
{
    public class KetNoi
    {

        private static SqlConnection cnn;

        public static SqlConnection Cnn
        {
            get { return KetNoi.cnn; }
            set { KetNoi.cnn = value; }
        }

        public bool ktKetNoi(string pTenMay,string pTenCSDL,string pUser,string pPass)
        {
            try
            {
                cnn = new SqlConnection("Data Source=" + pTenMay + ";Initial Catalog=" + pTenCSDL + ";User ID=" + pUser + ";Password=" + pPass);
                cnn.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
