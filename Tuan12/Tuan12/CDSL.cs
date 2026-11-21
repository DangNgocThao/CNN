using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Tuan12
{
    public class CDSL
    {
        SqlConnection cnn = new SqlConnection("Data Source=LAPTOP-HP348G7;Initial Catalog=QLSINHVIEN;Integrated Security=True");
        DataSet QLSV = new DataSet();
        public DataTable loadLop()
        { 
            string caulenh="select * from Lop";
            SqlDataAdapter dsLop=new SqlDataAdapter(caulenh,cnn);
            dsLop.Fill(QLSV,"Lop");
            return QLSV.Tables["Lop"];
        }
        public DataTable loadSV(string pMaLop)
        {
            string caulenh = "select * from View_sv where MaLop='" + pMaLop + "'";
            SqlDataAdapter dsSV = new SqlDataAdapter(caulenh, cnn);
            if (QLSV.Tables.Contains("SinhVien"))
                QLSV.Tables["SinhVien"].Clear();
            dsSV.Fill(QLSV, "SinhVien");
            return QLSV.Tables["SinhVien"];
        }
    }
}
