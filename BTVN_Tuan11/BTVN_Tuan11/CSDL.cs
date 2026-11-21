using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BTVN_Tuan11
{
    public class CSDL
    {
        SqlConnection _cnn = new SqlConnection("Data Source=LAPTOP-HP348G7;Initial Catalog=QLSINHVIEN;Integrated Security=True");
        DataSet QLSinhVien = new DataSet();
        SqlDataAdapter dsLop;
        SqlDataAdapter dsKhoa;
        public DataTable LoadLop()
        {
            string cauLenh = "select * from Lop";
            dsLop = new SqlDataAdapter(cauLenh, _cnn);
            dsLop.Fill(QLSinhVien, "Lop");
            DataColumn[] cot = new DataColumn[1];
            cot[0] = QLSinhVien.Tables["Lop"].Columns[0];
            QLSinhVien.Tables["Lop"].PrimaryKey = cot;
            return QLSinhVien.Tables["Lop"];
        }
        public DataTable LoadKhoa()
        {
            string cauLenh = "select * from Khoa";
            dsKhoa = new SqlDataAdapter(cauLenh, _cnn);
            dsKhoa.Fill(QLSinhVien, "Khoa");
            DataColumn[] cot = new DataColumn[1];
            cot[0] = QLSinhVien.Tables["Khoa"].Columns[0];
            QLSinhVien.Tables["Khoa"].PrimaryKey = cot;
            return QLSinhVien.Tables["Khoa"];
        }

        public bool xoaLop(string pMaLop)
        {
            try
            {
                DataRow dong = QLSinhVien.Tables["Lop"].Rows.Find(pMaLop);
                if (dong != null)
                    dong.Delete();
                SqlCommandBuilder cmd = new SqlCommandBuilder(dsLop);
                dsLop.Update(QLSinhVien, "Lop");
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool LuuLop()
        {
            try
            {
                SqlCommandBuilder cmd = new SqlCommandBuilder(dsLop);
                dsLop.Update(QLSinhVien, "Lop");

                return true;
            }
            catch
            {

                return false;
            }
        }

    }
}
