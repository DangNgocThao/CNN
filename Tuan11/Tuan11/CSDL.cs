using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Tuan11
{
    public class CSDL
    {
        SqlConnection _cnn = new SqlConnection("Data Source=LAPTOP-HP348G7;Initial Catalog=QLSINHVIEN;Integrated Security=True");
        DataSet QLSinhVien = new DataSet();
        SqlDataAdapter dsLop;
        SqlDataAdapter dsSV;
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
        public DataTable LoadSV()
        {
            string cauLenh = "select * from SinhVien";
            dsSV = new SqlDataAdapter(cauLenh, _cnn);
            dsSV.Fill(QLSinhVien, "SinhVien");
            DataColumn[] cot = new DataColumn[1];
            cot[0] = QLSinhVien.Tables["SinhVien"].Columns[0];
            QLSinhVien.Tables["SinhVien"].PrimaryKey = cot;
            return QLSinhVien.Tables["SinhVien"];
        }

        public bool xoaSV(string pMaSV)
        {
            try
            {
                DataRow dong = QLSinhVien.Tables["SinhVien"].Rows.Find(pMaSV);
                if (dong != null)
                    dong.Delete();
                SqlCommandBuilder cmd = new SqlCommandBuilder(dsSV);
                dsSV.Update(QLSinhVien, "SinhVien");
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool LuuSV()
        {
            try
            {
                SqlCommandBuilder cmd = new SqlCommandBuilder(dsSV);
                dsSV.Update(QLSinhVien, "SinhVien");

                return true;
            }
            catch
            {

                return false;
            }
        }

    }
}
