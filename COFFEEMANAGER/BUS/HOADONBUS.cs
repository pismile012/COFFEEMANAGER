using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COFFEEMANAGER.DAO;
using COFFEEMANAGER.DTO;
using System.Data;

namespace COFFEEMANAGER.BUS
{
    public class HOADONBUS
    {
        private static HOADONBUS instance;
        public static HOADONBUS Instance
        {
            get { if (instance == null) instance = new HOADONBUS(); return instance; }
            private set { instance = value; }
        }
        public DataTable getallhoadon()
        {
            HOADONDAO dao = new HOADONDAO();
            return dao.getallhoadon();
        }
        public DataTable SearchHoaDon(string mach, string datecheckout, string status)
        {
            HOADONDAO dao = new HOADONDAO();
            return dao.SearchHoaDon(mach, datecheckout, status);
        }
        public DataTable GetMaHd()
        {
            HOADONDAO dao = new HOADONDAO();
            return dao.GetMaHd();
        }
        public int ThanhToan(HOADON hoadon)
        {
            HOADONDAO dao = new HOADONDAO();
            return dao.ThanhToan(hoadon);
        }

    }
}
