using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Tuan8
{
    public class CSDL
    {
        SqlConnection _cnn = new SqlConnection("Data Source = A111PC19; Initial Catalog = QLSINHVIEN; User ID = sa; Password = 123");
        public CSDL()
        {

        }
        public int ktTrung(string s)
        {
            try
            {
                if (_cnn.State == System.Data.ConnectionState.Closed)
                    _cnn.Open();
                string CauLenh = s;
                SqlCommand cmd = new SqlCommand(CauLenh, _cnn);
                int kq = (int)cmd.ExecuteScalar();
                if (_cnn.State == System.Data.ConnectionState.Open)
                    _cnn.Close();
                return kq;
            }
            catch
            {
                return -1;
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
        public List<string> LayDL(string s)
        {
            List<string> ds = new List<string>();
            if (_cnn.State == System.Data.ConnectionState.Closed)
                _cnn.Open();
            string CauLenh = s;
            SqlCommand cmd = new SqlCommand(CauLenh, _cnn);
            SqlDataReader kq = cmd.ExecuteReader();
            while (kq.Read())
            {
                string mk = kq[0].ToString();
                ds.Add(mk);
            }
            if (_cnn.State == System.Data.ConnectionState.Open)
                _cnn.Close();
            return ds;
        }
        public List<lop_khoa> ListLopKhoa()
        {
            List<lop_khoa> ds = new List<lop_khoa>();
            if (_cnn.State == System.Data.ConnectionState.Closed)
                _cnn.Open();
            string CauLenh = "select * from Lop";
            SqlCommand cmd = new SqlCommand(CauLenh, _cnn);
            SqlDataReader kq = cmd.ExecuteReader();
            while (kq.Read())
            {
                lop_khoa mk = new lop_khoa(kq[0].ToString(), kq[1].ToString(), kq[2].ToString());                
                ds.Add(mk);
            }
            if (_cnn.State == System.Data.ConnectionState.Open)
                _cnn.Close();
            return ds;
        }
    }
}