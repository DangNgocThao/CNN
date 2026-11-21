using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Tuan9
{
    public class CSDL
    {
        SqlConnection _cnn = new SqlConnection("Data Source=LAPTOP-HP348G7;Initial Catalog=QLSINHVIEN;Integrated Security=True");
        DataSet ds_QLSINHVIEN = new DataSet();
        SqlDataAdapter da_SinhVien;
        SqlDataAdapter da_MonHoc;
        SqlDataAdapter da_Diem;
        public CSDL()
        {

        }
        public DataTable LoadSinhVien()
        {
            string CauLenh = "select * from SinhVien";

            da_SinhVien = new SqlDataAdapter(CauLenh, _cnn);

            da_SinhVien.Fill(ds_QLSINHVIEN, "SinhVien");

            DataColumn[] keys = new DataColumn[1];
            keys[0] = ds_QLSINHVIEN.Tables["SinhVien"].Columns[0];
            ds_QLSINHVIEN.Tables["SinhVien"].PrimaryKey = keys;

            return ds_QLSINHVIEN.Tables["SinhVien"];
        }
        public DataTable LoadMonHoc()
        {
            string CauLenh = "select * from MonHoc";

            da_MonHoc = new SqlDataAdapter(CauLenh, _cnn);

            da_MonHoc.Fill(ds_QLSINHVIEN, "MonHoc");

            DataColumn[] keys = new DataColumn[1];
            keys[0] = ds_QLSINHVIEN.Tables["MonHoc"].Columns[0];
            ds_QLSINHVIEN.Tables["MonHoc"].PrimaryKey = keys;

            return ds_QLSINHVIEN.Tables["MonHoc"];
        }
        public DataTable LoadDiem()
        {
            string CauLenh = "select * from Diem";

            da_Diem = new SqlDataAdapter(CauLenh, _cnn);

            da_Diem.Fill(ds_QLSINHVIEN, "Diem");

            DataColumn[] keys = new DataColumn[2];
            keys[0] = ds_QLSINHVIEN.Tables["Diem"].Columns[0];
            keys[1] = ds_QLSINHVIEN.Tables["Diem"].Columns[1];
            ds_QLSINHVIEN.Tables["Diem"].PrimaryKey = keys;

            return ds_QLSINHVIEN.Tables["Diem"];
        }
        public DataTable LoadDGV(string s)
        {
            string CauLenh = s;

            SqlDataAdapter da_FullDiem = new SqlDataAdapter(CauLenh, _cnn);

            if (ds_QLSINHVIEN.Tables.Contains("FullDiem"))
                ds_QLSINHVIEN.Tables["FullDiem"].Rows.Clear();

            da_FullDiem.Fill(ds_QLSINHVIEN, "FullDiem");

            return ds_QLSINHVIEN.Tables["FullDiem"];
        }
        public DataTable LoadFullDiem()
        {
            return LoadDGV("select d.MaSinhVien,HoTen,TenLop,d.MaMonHoc,TenMonHoc,Diem from Diem d,SinhVien sv,MonHoc mh,Lop l where mh.MaMonHoc=d.MaMonHoc and d.MaSinhVien=sv.MaSinhVien and sv.MaLop=l.MaLop");
        }
        public DataTable LoadDiemTheoSV(string s)
        {
            return LoadDGV("select d.MaSinhVien,HoTen,TenLop,d.MaMonHoc,TenMonHoc,Diem from Diem d,SinhVien sv,MonHoc mh,Lop l where mh.MaMonHoc=d.MaMonHoc and d.MaSinhVien=sv.MaSinhVien and sv.MaLop=l.MaLop and d.MaSinhVien=" + s + "");
        }
        public DataTable LoadDiemTheoMH(string s)
        {
            return LoadDGV("select d.MaSinhVien,HoTen,TenLop,d.MaMonHoc,TenMonHoc,Diem from Diem d,SinhVien sv,MonHoc mh,Lop l where mh.MaMonHoc=d.MaMonHoc and d.MaSinhVien=sv.MaSinhVien and sv.MaLop=l.MaLop and d.MaMonHoc='" + s + "'");
        }
        public bool ThemDiem(string pMaSV, string pMaMH, string pDiem)
        {
            try
            {
                DataRow dong = ds_QLSINHVIEN.Tables["Diem"].NewRow();

                dong[0] = pMaSV;
                dong[1] = pMaMH;
                dong[2] = pDiem;

                ds_QLSINHVIEN.Tables["Diem"].Rows.Add(dong);

                SqlCommandBuilder build_diem = new SqlCommandBuilder(da_Diem);

                da_Diem.Update(ds_QLSINHVIEN, "Diem");

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaDiem(string pMaSV, string pMaMH)
        {
            try
            {
                object[] f = new object[2];
                f[0] = pMaSV;
                f[1] = pMaMH;

                DataRow dong = ds_QLSINHVIEN.Tables["Diem"].Rows.Find(f);

                if (dong != null)
                    dong.Delete();

                SqlCommandBuilder build_diem = new SqlCommandBuilder(da_Diem);

                da_Diem.Update(ds_QLSINHVIEN, "Diem");

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SuaDiem(string pMaSV, string pMaMH, string pDiem)
        {
            try
            {
                object[] f = new object[2];
                f[0] = pMaSV;
                f[1] = pMaMH;

                DataRow dong = ds_QLSINHVIEN.Tables["Diem"].Rows.Find(f);

                if (dong != null)
                {
                    dong[2] = pDiem;
                }

                SqlCommandBuilder build_diem = new SqlCommandBuilder(da_Diem);

                da_Diem.Update(ds_QLSINHVIEN, "Diem");

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
