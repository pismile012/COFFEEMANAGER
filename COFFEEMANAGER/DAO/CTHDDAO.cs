using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using COFFEEMANAGER.DTO;

namespace COFFEEMANAGER.DAO
{
    public class CTHDDAO
    {
        private static CTHDDAO instance;

        public static CTHDDAO Instance
        {
            get { if (instance == null) instance = new CTHDDAO(); return CTHDDAO.instance; }
            private set { CTHDDAO.instance = value; }
        }

        public CTHDDAO() { }

        public int CreateBilll (CREATEBILL bill)
        {
            Provider p = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "hoadon_insert";
                p.Connect();
                nRow = p.ExcecuteNonQuery(CommandType.StoredProcedure, strSQL,
                        new SqlParameter { ParameterName = "@mamon", Value = bill.MAMON },
                        new SqlParameter { ParameterName = "@mahd", Value = bill.MAHD },
                        new SqlParameter { ParameterName = "@soluong", Value = bill.SOLUONG },
                        new SqlParameter { ParameterName = "@status", Value = bill.TRANGTHAI }
                    );
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                p.DisConnect();
            }
            return nRow;
        }
        public int Delete(string mahd)
        {
            Provider p = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "chitiethoadon_Delete";
                p.Connect();
                nRow = p.ExcecuteNonQuery(CommandType.StoredProcedure, strSQL,
                        new SqlParameter { ParameterName = "@mahd", Value = mahd });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                p.DisConnect();
            }
            return nRow;
        }
        public DataTable GetCTHD(string macthd)
        {
            Provider p = new Provider();
            DataTable dt = null;
            try
            {
                string strSQL = "chitiethoadon_getall";
                p.Connect();
                dt = p.ExcecuteQuery(CommandType.StoredProcedure, strSQL,
                    new SqlParameter { ParameterName = "@macthd", Value = macthd });
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                p.DisConnect();
            }
            return dt;

        }
        public List<CTHD> GetHoaDon(string macthd)
        {
            Provider p = new Provider();
            DataTable dt = null;
            List<CTHD> listCthd = new List<CTHD>();
            try
            {
                string strSQL = "chitiethoadon_getdetail";
                p.Connect();
                dt = p.ExcecuteQuery(CommandType.StoredProcedure, strSQL,
                    new SqlParameter { ParameterName = "@macthd", Value = macthd });
                foreach(DataRow item in dt.Rows)
                {
                    CTHD chitiethoadon = new CTHD(item);
                    listCthd.Add(chitiethoadon);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                p.DisConnect();
            }
            return listCthd;

        }

       


    }
}
