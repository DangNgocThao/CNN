using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Tuan7
{
    public class CSDL
    {
        SqlConnection _cnn = new SqlConnection("Data Source = LAPTOP-HP348G7; Initial Catalog = QLSINHVIEN; Integrated Security = true");
        public CSDL()
        {

        }
        public bool kt()
        {
            try
            {
                if (_cnn.State == System.Data.ConnectionState.Closed)
                    _cnn.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool chucNang(string s)
        {
            try
            {
                if (_cnn.State == System.Data.ConnectionState.Closed)
                    _cnn.Open();
                string cauLenh = s;
                SqlCommand cmd = new SqlCommand(cauLenh, _cnn);
                cmd.ExecuteNonQuery();
                if (_cnn.State == System.Data.ConnectionState.Open)
                    _cnn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
