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
    public class CUAHANGDAO
    {
        private static CUAHANGDAO instance;
        public static CUAHANGDAO Instance
        {
            get { if (instance == null) instance = new CUAHANGDAO(); return CUAHANGDAO.instance; }
            private set { CUAHANGDAO.instance = value; }
        }
        public List<CUAHANG> GetListCuaHang()
        {
            List<CUAHANG> list = new List<CUAHANG>();
            string query = "cuahang_getall";
            Provider p = new Provider();
            p.Connect();
            DataTable dt = Provider.Instance.ExeQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                CUAHANG cuahang = new CUAHANG(item);
                list.Add(cuahang);
            }
            return list;
        }
    }
}
