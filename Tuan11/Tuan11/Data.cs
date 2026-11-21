using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Tuan11
{
    public class Data
    {
        SqlConnection _cnn = new SqlConnection("Data Source=LAPTOP-HP348G7;Initial Catalog=QLSINHVIEN;Integrated Security=True");
        DataSet QLSinhVien = new DataSet();
        SqlDataAdapter dsMH;
        SqlDataAdapter dsSV;
        SqlDataAdapter dsDiem;
        public DataTable LoadMH()
        {
            string cauLenh = "select * from MonHoc";
            dsMH = new SqlDataAdapter(cauLenh, _cnn);
            dsMH.Fill(QLSinhVien, "MonHoc");
            DataColumn[] cot = new DataColumn[1];
            cot[0] = QLSinhVien.Tables["MonHoc"].Columns[0];
            QLSinhVien.Tables["MonHoc"].PrimaryKey = cot;
            return QLSinhVien.Tables["MonHoc"];
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
        public DataTable LoadDiem()
        {
            string cauLenh = "select * from Diem";
            dsDiem = new SqlDataAdapter(cauLenh, _cnn);
            dsDiem.Fill(QLSinhVien, "Diem");
            DataColumn[] cot = new DataColumn[2];
            cot[0] = QLSinhVien.Tables["Diem"].Columns[0];
            cot[1] = QLSinhVien.Tables["Diem"].Columns[1];
            QLSinhVien.Tables["Diem"].PrimaryKey = cot;
            return QLSinhVien.Tables["Diem"];
        }
        public bool xoaDiem(string pMaSV, string pMaMH)
        {
            try
            {
                object[] t = new object[2];
                t[0] = pMaSV;
                t[1] = pMaMH;
                DataRow dong = QLSinhVien.Tables["Diem"].Rows.Find(t);
                if (dong != null)
                    dong.Delete();
                SqlCommandBuilder cmd = new SqlCommandBuilder(dsDiem);
                dsDiem.Update(QLSinhVien, "Diem");
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool LuuDiem()
        {
            try
            {
                SqlCommandBuilder cmd = new SqlCommandBuilder(dsDiem);
                dsDiem.Update(QLSinhVien, "Diem");

                return true;
            }
            catch
            {

                return false;
            }
        }
    }
}
