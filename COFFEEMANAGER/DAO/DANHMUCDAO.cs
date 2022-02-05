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
    public class DANHMUCDAO
    {
        private static DANHMUCDAO instance;

        public static DANHMUCDAO Instance
        {
            get { if (instance == null) instance = new DANHMUCDAO(); return DANHMUCDAO.instance; }
            private set { DANHMUCDAO.instance = value; }
        }

        public DANHMUCDAO() { }
        public List<DANHMUC> GetListDanhMuc()
        {
            Provider p = new Provider();
            DataTable dt = null;
            List<DANHMUC> listCthd = new List<DANHMUC>();
            try
            {
                string strSQL = "danhmuc_getlist";
                p.Connect();
                dt = p.ExcecuteQuery(CommandType.StoredProcedure, strSQL);
                foreach (DataRow item in dt.Rows)
                {
                    DANHMUC madanhmuc  = new DANHMUC(item);
                    listCthd.Add(madanhmuc);
                }
            }
            catch (Exception ex)
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
