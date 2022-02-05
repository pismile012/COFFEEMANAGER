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
    public class QuanlymonDAO
    {
        public int ThemMon(Mon mon)
        {
            Provider p = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "sp_ThemMon";
                p.Connect();
                nRow = p.ExcecuteNonQuery(CommandType.StoredProcedure, strSQL,
                        new SqlParameter { ParameterName = "@mamon", Value = mon.Mamon },
                        new SqlParameter { ParameterName = "@tenmon", Value = mon.Tenmon },
                        new SqlParameter { ParameterName = "@gia", Value = mon.Gia },
                        new SqlParameter { ParameterName = "@madm", Value = mon.Madm }
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

        public int XoaMon(string mamoncanxoa)
        {
            Provider p = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "sp_XoaMon";
                p.Connect();
                nRow = p.ExcecuteNonQuery(CommandType.StoredProcedure, strSQL,
                        new SqlParameter { ParameterName = "@mamoncanxoa", Value = mamoncanxoa });
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

        public int SuaMon(Mon mon)
        {
            Provider p = new Provider();
            int nRow = 0;
            try
            {
                string strSQL = "sp_SuaMon";
                p.Connect();
                nRow = p.ExcecuteNonQuery(CommandType.StoredProcedure, strSQL,
                        new SqlParameter { ParameterName = "@mamon", Value = mon.Mamon },
                        new SqlParameter { ParameterName = "@tenmon", Value = mon.Tenmon },
                        new SqlParameter { ParameterName = "@gia", Value = mon.Gia },
                        new SqlParameter { ParameterName = "@madm", Value = mon.Madm }
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
        public DataTable TimKiemMonTheoTen(string tenmon)
        {
            Provider p = new Provider();
            DataTable dt = null;
            try
            {
                string strSQL = "sp_TimKiemMonTheoTen";
                p.Connect();
                dt = p.ExcecuteQuery(CommandType.StoredProcedure, strSQL,
                    new SqlParameter { ParameterName = "@tenmon", Value = tenmon });
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
        public DataTable LoatDataMon()
        {
            Provider p = new Provider();
            DataTable dt = null;
            try
            {
                string strSQL = "sp_LoadDataMon";
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

        public DataTable LoatDataDanhmuc()
        {
            Provider p = new Provider();
            DataTable dt = null;
            try
            {
                string strSQL = "sp_LoatDataDanhmuc";
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
