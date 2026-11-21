using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Tuan10
{
    public class CSDL
    {
        SqlConnection _cnn = new SqlConnection("Data Source=LAPTOP-HP348G7;Initial Catalog=QLSINHVIEN;Integrated Security=True");
        DataSet QL_SV = new DataSet();
        SqlDataAdapter da_khoa;
        public DataTable loadKhoa()
        {
            string cauLenh = "select * from Khoa";

            da_khoa = new SqlDataAdapter(cauLenh, _cnn);

            da_khoa.Fill(QL_SV, "Khoa");

            DataColumn[] key = new DataColumn[1];
            key[0] = QL_SV.Tables["Khoa"].Columns[0];
            QL_SV.Tables["Khoa"].PrimaryKey = key;

            return QL_SV.Tables["Khoa"];
        }
        public bool themKhoa(string pMaKhoa,string pTenKhoa)
        {
            try
            {
                DataRow dong = QL_SV.Tables["Khoa"].NewRow();
                dong[0] = pMaKhoa;
                dong[1] = pTenKhoa;

                QL_SV.Tables["Khoa"].Rows.Add(dong);

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool xoaKhoa(string pMaKhoa)
        {
            try
            {
                DataRow dong = QL_SV.Tables["Khoa"].Rows.Find(pMaKhoa);

                if (dong != null)
                    dong.Delete();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool suaKhoa(string pMaKhoa, string pTenKhoa)
        {
            try
            {
                DataRow dong = QL_SV.Tables["Khoa"].Rows.Find(pMaKhoa);

                if (dong != null)
                    dong[1] = pTenKhoa;

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool luuKhoa()
        {
            try
            {
                SqlCommandBuilder buildKhoa = new SqlCommandBuilder(da_khoa);

                da_khoa.Update(QL_SV,"Khoa");

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
