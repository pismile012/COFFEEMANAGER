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
    public class CTHDBUS
    {
        private static CTHDBUS instance;
        public static CTHDBUS Instance
        {
            get { if (instance == null) instance = new CTHDBUS(); return instance; }
            private set { instance = value; }
        }
        public int CreateBillBus(CREATEBILL bill)
        {
            CTHDDAO dao = new CTHDDAO();
            return dao.CreateBilll(bill);
        }
        public int Delete(string mahd)
        {
            CTHDDAO dao = new CTHDDAO();
            return dao.Delete(mahd);
        }
        public DataTable GetCTHD(string macthd)
        {
            CTHDDAO dao = new CTHDDAO();
            return dao.GetCTHD(macthd);
        }

    }
}
