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
    public class QuanlybanDAO
    {
        public int ThemBan(Ban ban)
        {
            Provider p = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "sp_ThemBan";
                p.Connect();
                nRow = p.ExcecuteNonQuery(CommandType.StoredProcedure, strSQL,
                        new SqlParameter { ParameterName = "@mach", Value = ban.Mach },
                        new SqlParameter { ParameterName = "@mamon", Value = ban.Mamon }

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
        public int XoaBan(string machcanxoa)
        {
            Provider p = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "sp_XoaBan";
                p.Connect();
                nRow = p.ExcecuteNonQuery(CommandType.StoredProcedure, strSQL,
                        new SqlParameter { ParameterName = "@machcanxoa", Value = machcanxoa }

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
        public DataTable TimKiemBanTheoTen(string mach)
        {
            Provider p = new Provider();
            DataTable dt = null;
            try
            {
                string strSQL = "sp_TimKiemBanTheoTen";
                p.Connect();
                dt = p.ExcecuteQuery(CommandType.StoredProcedure, strSQL,
                    new SqlParameter { ParameterName = "@mach", Value = mach });
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
        public DataTable LoatDataBan()
        {
            Provider p = new Provider();
            DataTable dt = null;
            try
            {
                string strSQL = "sp_LoadDataBan";
                p.Connect();
                dt = p.ExcecuteQuery(CommandType.StoredProcedure, strSQL);
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

        public DataTable LoatDataMon()
        {
            Provider p = new Provider();
            DataTable dt = null;
            try
            {
                string strSQL = "sp_LoatDataMon";
                p.Connect();
                dt = p.ExcecuteQuery(CommandType.StoredProcedure, strSQL);
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
    }
}
