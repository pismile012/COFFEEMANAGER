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
    public class MONDANHMUCDAO
    {
        private static MONDANHMUCDAO instance;

        public static MONDANHMUCDAO Instance
        {
            get { if (instance == null) instance = new MONDANHMUCDAO(); return MONDANHMUCDAO.instance; }
            private set { MONDANHMUCDAO.instance = value; }
        }

        public MONDANHMUCDAO() { }
        public List<MONDANHMUC> GetListMon(string madm)
        {
            Provider p = new Provider();
            DataTable dt = null;
            List<MONDANHMUC> listCthd = new List<MONDANHMUC>();
            try
            {
                string strSQL = "mon_getlist";
                p.Connect();
                dt = p.ExcecuteQuery(CommandType.StoredProcedure, strSQL,
                    new SqlParameter { ParameterName = "@madm", Value = madm });
                foreach (DataRow item in dt.Rows)
                {
                    MONDANHMUC mamon = new MONDANHMUC(item);
                    listCthd.Add(mamon);
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
