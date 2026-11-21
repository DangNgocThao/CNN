using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Tuan8
{
    public class CSDL
    {
        SqlConnection _cnn = new SqlConnection("Data Source = LAPTOP-HP348G7; Initial Catalog = QLCuaHang; Integrated Security = true");
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
        public bool chucNang(string cauLenh)
        {
            try
            {
                if (_cnn.State == System.Data.ConnectionState.Closed)
                    _cnn.Open();
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
        public bool themSP(string pTenSP)
        {
            return chucNang("insert into SANPHAM values(N'" + pTenSP + "')");
        }
        public bool themTonKho(string pTenSP)
        {
            if (_cnn.State == System.Data.ConnectionState.Closed)
                _cnn.Open();
            SqlCommand cmd = new SqlCommand("select MaSP from SANPHAM where TenSP=N'" + pTenSP + "'", _cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int masp = (int)reader[0];
            if (_cnn.State == System.Data.ConnectionState.Open)
                _cnn.Close();
            return chucNang("insert into TONKHO values (" + masp + ",GETDATE(),0,0,0)");
        }
        public bool themHD()
        {
            return chucNang("insert into HOADON values (GETDATE(),0)");
        }
        public bool updateHD(string pMaHD)
        {
            return chucNang("update HOADON set TinhTrangThanhToan=1 where MaHD =" + pMaHD + "");
        }
        public bool themChiTietHD(string pMaHD, string pMaSP, string sl)
        {
            return chucNang("insert into CHITIET_HOADON values('" + pMaHD + "','" + pMaSP + "','" + sl + "')");
        }
        public bool updateTonKho()
        {
            return chucNang("update TONKHO set NgayTon=GETDATE(),SLDau=SLDau+SLNhap-SLBan,SLBan=0,SLNhap=0");
        }
        public bool updateSLBan(string pMaSP, string pSLBan)
        {
            return chucNang("update TONKHO set SLBan=SLBan+" + pSLBan + "where MaSP=" + pMaSP + "");
        }
        public bool resetSLBan()
        {
            return chucNang("update TONKHO set SLBan=0");
        }
        public int layMaHDVuaThem()
        {
            if (_cnn.State == System.Data.ConnectionState.Closed)
                _cnn.Open();
            SqlCommand cmd = new SqlCommand("select MaHD from HOADON", _cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            int mahd = -1;
            while (reader.Read())
            {
                mahd = (int)reader[0];
            }
            if (_cnn.State == System.Data.ConnectionState.Open)
                _cnn.Close();
            return mahd;
        }
        public List<string> layDL(string CauLenh)
        {
            List<string> ds = new List<string>();
            if (_cnn.State == System.Data.ConnectionState.Closed)
                _cnn.Open();
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
        public int laySLDau(string pMaSP)
        {
            if (_cnn.State == System.Data.ConnectionState.Closed)
                _cnn.Open();
            SqlCommand cmd = new SqlCommand("select SLDau from TONKHO where MaSP=" + pMaSP + "", _cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            int slDau = -1;
            reader.Read();
            slDau = (int)reader[0];
            if (_cnn.State == System.Data.ConnectionState.Open)
                _cnn.Close();
            return slDau;
        }
        public List<string> loadMaSP()
        {
            return layDL("select MaSP from SANPHAM");
        }
    }
}
