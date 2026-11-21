using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Tuan9
{
    public class CSDL
    {
        SqlConnection _cnn = new SqlConnection("Data Source=LAPTOP-HP348G7;Initial Catalog=QLSINHVIEN;Integrated Security=True");
        DataSet ds_QLSINHVIEN = new DataSet();
        SqlDataAdapter da_Lop;
        SqlDataAdapter da_Khoa;
        public CSDL()
        {

        }
        public DataTable LoadKhoa()
        {
            string CauLenh = "select * from Khoa";

            da_Khoa = new SqlDataAdapter(CauLenh, _cnn);

            da_Khoa.Fill(ds_QLSINHVIEN, "Khoa");

            DataColumn[] keys = new DataColumn[1];
            keys[0] = ds_QLSINHVIEN.Tables["Khoa"].Columns[0];
            ds_QLSINHVIEN.Tables["Khoa"].PrimaryKey = keys;

            return ds_QLSINHVIEN.Tables["Khoa"];
        }
        public bool themKhoa(string pMaKhoa,string pTenKhoa)
        {
            try
            {
                DataRow dong =ds_QLSINHVIEN.Tables["Khoa"].NewRow();

                dong[0]=pMaKhoa;
                dong[1]=pTenKhoa;

                ds_QLSINHVIEN.Tables["Khoa"].Rows.Add(dong);

                SqlCommandBuilder build_khoa=new SqlCommandBuilder(da_Khoa);

                da_Khoa.Update(ds_QLSINHVIEN,"Khoa");

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool xoaKhoa(string pMaKhoa)
        {
            try
            {
                DataRow dong = ds_QLSINHVIEN.Tables["Khoa"].Rows.Find(pMaKhoa);

                if (dong != null)
                    dong.Delete();

                SqlCommandBuilder build_khoa = new SqlCommandBuilder(da_Khoa);

                da_Khoa.Update(ds_QLSINHVIEN, "Khoa");

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool suaKhoa(string pMaKhoa, string pTenKhoa)
        {
            try
            {
                DataRow dong = ds_QLSINHVIEN.Tables["Khoa"].Rows.Find(pMaKhoa);

                if (dong != null)
                    dong[1] = pTenKhoa;

                SqlCommandBuilder build_khoa = new SqlCommandBuilder(da_Khoa);

                da_Khoa.Update(ds_QLSINHVIEN, "Khoa");

                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable LoadLop()
        {
            string CauLenh = "select * from Lop";

            da_Lop = new SqlDataAdapter(CauLenh, _cnn);

            da_Lop.Fill(ds_QLSINHVIEN, "Lop");

            DataColumn[] keys = new DataColumn[1];
            keys[0] = ds_QLSINHVIEN.Tables["Lop"].Columns[0];
            ds_QLSINHVIEN.Tables["Lop"].PrimaryKey = keys;

            return ds_QLSINHVIEN.Tables["Lop"];
        }
        public bool ThemLop(string pMaLop,string pTenLop,string pMaKhoa)
        {
            try
            {
                DataRow dong = ds_QLSINHVIEN.Tables["Lop"].NewRow();

                dong[0] = pMaLop;
                dong[1] = pTenLop;
                dong[2] = pMaKhoa;

                ds_QLSINHVIEN.Tables["Lop"].Rows.Add(dong);

                SqlCommandBuilder build_lop = new SqlCommandBuilder(da_Lop);

                da_Lop.Update(ds_QLSINHVIEN, "Lop");

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaLop(string pMaLop)
        {
            try
            {
                DataRow dong = ds_QLSINHVIEN.Tables["Lop"].Rows.Find(pMaLop);

                if (dong != null)
                    dong.Delete();
                
                SqlCommandBuilder build_lop = new SqlCommandBuilder(da_Lop);

                da_Lop.Update(ds_QLSINHVIEN, "Lop");

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SuaLop(string pMaLop, string pTenLop, string pMaKhoa)
        {
            try
            {
                DataRow dong = ds_QLSINHVIEN.Tables["Lop"].Rows.Find(pMaLop);

                if (dong != null)
                {
                    dong[1] = pTenLop;
                    dong[2] = pMaKhoa;
                }

                SqlCommandBuilder build_lop = new SqlCommandBuilder(da_Lop);

                da_Lop.Update(ds_QLSINHVIEN, "Lop");

                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataTable LoadLopKhoa()
        {
            string CauLenh = "select MaLop, TenLop, k.MaKhoa, TenKhoa from Lop l, Khoa k where l.MaKhoa=k.MaKhoa";

            SqlDataAdapter da_LopKhoa = new SqlDataAdapter(CauLenh, _cnn);

            if (ds_QLSINHVIEN.Tables.Contains("LopKhoa"))
                ds_QLSINHVIEN.Tables["LopKhoa"].Rows.Clear();

            da_LopKhoa.Fill(ds_QLSINHVIEN, "LopKhoa");

            return ds_QLSINHVIEN.Tables["LopKhoa"];
        }
    }
}
