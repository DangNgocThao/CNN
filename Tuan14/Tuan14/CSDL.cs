using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Tuan14
{
    public class CSDL:KetNoi
    {
        DataSet QL_GIAOVIEN = new DataSet();
        SqlDataAdapter ds_CoSo;
        SqlDataAdapter ds_DonVi;
        SqlDataAdapter ds_GV;
        public DataTable loadCoSo()
        {
            string lenh = "select * from COSO";
            ds_CoSo = new SqlDataAdapter(lenh, Cnn);
            ds_CoSo.Fill(QL_GIAOVIEN, "COSO");
            DataColumn[] key = new DataColumn[1];
            key[0] = QL_GIAOVIEN.Tables["COSO"].Columns[0];
            QL_GIAOVIEN.Tables["COSO"].PrimaryKey = key;
            return QL_GIAOVIEN.Tables["COSO"];
        }
        public DataTable loadDonVi()
        {
            string lenh = "select * from DONVI";
            ds_DonVi = new SqlDataAdapter(lenh, Cnn);
            ds_DonVi.Fill(QL_GIAOVIEN, "DONVI");
            DataColumn[] key = new DataColumn[1];
            key[0] = QL_GIAOVIEN.Tables["DONVI"].Columns[0];
            QL_GIAOVIEN.Tables["DONVI"].PrimaryKey = key;
            return QL_GIAOVIEN.Tables["DONVI"];
        }
        public DataTable loadView()
        {
            string lenh = "select HOTEN,MAGV,MADONVI from GV";
            ds_GV = new SqlDataAdapter(lenh, Cnn);
            ds_GV.Fill(QL_GIAOVIEN, "GV");
            DataColumn[] key = new DataColumn[1];
            key[0] = QL_GIAOVIEN.Tables["GV"].Columns[1];
            QL_GIAOVIEN.Tables["GV"].PrimaryKey = key;
            return QL_GIAOVIEN.Tables["GV"];
        }
        public bool xoaGV(string pMaGV)
        {
            try
            {
                DataRow d = QL_GIAOVIEN.Tables["GV"].Rows.Find(pMaGV);
                if (d != null)
                    d.Delete();
                SqlCommandBuilder b = new SqlCommandBuilder(ds_GV);
                ds_GV.Update(QL_GIAOVIEN, "GV");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataTable loadTT()
        {
            string lenh = "select MAGV, HOTEN, SDT, GHICHU, TENDONVI, TENCOSO from GV,DONVI,COSO where GV.MADONVI=DONVI.MADONVI and DONVI.MACOSO = COSO.MACOSO";
            SqlDataAdapter tt = new SqlDataAdapter(lenh, Cnn);
            tt.Fill(QL_GIAOVIEN, "TT");
            return QL_GIAOVIEN.Tables["TT"];
        }
    }
}
