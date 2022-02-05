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
    public class QLBan
    {
        public int ThemBan(Ban ban)
        {
            QuanlybanDAO dao = new QuanlybanDAO();
            return dao.ThemBan(ban);
        }
        public int XoaBan(string machcanxoa)
        {
            QuanlybanDAO dao = new QuanlybanDAO();
            return dao.XoaBan(machcanxoa);
        }
        public DataTable TimKiemBanTheoTen(string mach)
        {
            QuanlybanDAO dao = new QuanlybanDAO();
            return dao.TimKiemBanTheoTen(mach);
        }
        public DataTable LoatDataMon()
        {
            QuanlybanDAO dao = new QuanlybanDAO();
            return dao.LoatDataMon();
        }
        public DataTable LoatDataBan()
        {
            QuanlybanDAO dao = new QuanlybanDAO();
            return dao.LoatDataBan();
        }
    }
}
