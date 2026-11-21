using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan10
{
    public class Data
    {
        SqlConnection _cnn = new SqlConnection("Data Source=LAPTOP-HP348G7;Initial Catalog=QLSINHVIEN;Integrated Security=True");
        DataSet QLSinhVien = new DataSet();
        SqlDataAdapter dsLopKhoa;
        SqlDataAdapter dsSV;
        public DataTable LoadLopKhoa()
        {
            string cauLenh = "select TenLop, TenKhoa from Lop, Khoa where Khoa.MaKhoa=Lop.MaKhoa";
            dsLopKhoa = new SqlDataAdapter(cauLenh, _cnn);
            dsLopKhoa.Fill(QLSinhVien, "LopKhoa");
            return QLSinhVien.Tables["LopKhoa"];
        }
        public DataTable LoadSV()
        {
            string cauLenh = "select MaSinhVien, HoTen, NgaySinh, TenLop from SinhVien, Lop where Lop.MaLop=SinhVien.MaLop";
            dsSV = new SqlDataAdapter(cauLenh, _cnn);
            dsSV.Fill(QLSinhVien, "SinhVien");
            DataColumn[] cot = new DataColumn[1];
            cot[0] = QLSinhVien.Tables["SinhVien"].Columns[0];
            QLSinhVien.Tables["SinhVien"].PrimaryKey = cot;
            return QLSinhVien.Tables["SinhVien"];
        }
    }
}
