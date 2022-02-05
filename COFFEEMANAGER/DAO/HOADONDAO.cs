using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using COFFEEMANAGER.DTO;

namespace COFFEEMANAGER.DAO
{
    public class HOADONDAO
    {
        private static HOADONDAO instance;

        public static HOADONDAO Instance
        {
            get { if (instance == null) instance = new HOADONDAO(); return HOADONDAO.instance; }
            private set { HOADONDAO.instance = value; }
        }

        public HOADONDAO() { }
        public List<MAHOADON> GetListMaHd()
        {
            Provider p = new Provider();
            DataTable dt = null;
            List<MAHOADON> listCthd = new List<MAHOADON>();
            try
            {
                string strSQL = "chitiethoadon_getlistmahd";
                p.Connect();
                dt = p.ExcecuteQuery(CommandType.StoredProcedure, strSQL);
                foreach (DataRow item in dt.Rows)
                {
                    MAHOADON mahoadon  = new MAHOADON(item);
                    listCthd.Add(mahoadon);
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
        public DataTable SearchHoaDon(string mach, string datecheckout, string status)
        {
            Provider p = new Provider();
            datecheckout = Convert.ToDateTime(datecheckout).ToString("dd/MM/yyyy");
            DataTable dt = null;
            try
            {
                string strSQL = "hoadon_getall";

                p.Connect();
                dt = p.ExcecuteQuery(CommandType.StoredProcedure, strSQL,
                    new SqlParameter { ParameterName = "@mach", Value = mach },
                    new SqlParameter { ParameterName = "@datecheckout", Value = datecheckout },
                    new SqlParameter { ParameterName = "@status", Value = status });
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
        public DataTable getallhoadon()
        {
            Provider p = new Provider();
            DataTable dt = null;
            try
            {
                string strSql = "hoadon_getall";
                p.Connect();
                dt = p.ExcecuteQuery(CommandType.StoredProcedure, strSql);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                p.DisConnect();
            }
            return dt;

        }
        public DataTable GetMaHd()
        {
            Provider p = new Provider();
            DataTable dt = null;
            try
            {
                string strSql = "hoadon_gethoadon";
                p.Connect();
                dt = p.ExcecuteQuery(CommandType.StoredProcedure, strSql);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                p.DisConnect();
            }
            return dt;
        }

        public int ThanhToan(HOADON hoadon)
        {
            Provider p = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "hoadon_thanhtoan";
                p.Connect();
                nRow = p.ExcecuteNonQuery(CommandType.StoredProcedure, strSQL,
                        new SqlParameter { ParameterName = "@mahd", Value = hoadon.MAHD });
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
    }
}
