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
    public class QLMon
    {
        public int ThemMon(Mon mon)
        {
            QuanlymonDAO dao = new QuanlymonDAO();
            return dao.ThemMon(mon);
        }

        public int XoaMon(string mamoncanxoa)
        {
            QuanlymonDAO dao = new QuanlymonDAO();
            return dao.XoaMon(mamoncanxoa);
        }

        public int SuaMon(Mon mon)
        {
            QuanlymonDAO dao = new QuanlymonDAO();
            return dao.SuaMon(mon);
        }
        public DataTable TimKiemMonTheoTen(string tenmon)
        {
            QuanlymonDAO dao = new QuanlymonDAO();
            return dao.TimKiemMonTheoTen(tenmon);
        }

        public DataTable LoatDataDanhmuc()
        {
            QuanlymonDAO dao = new QuanlymonDAO();
            return dao.LoatDataDanhmuc();
        }
        public DataTable LoatDataMon()
        {
            QuanlymonDAO dao = new QuanlymonDAO();
            return dao.LoatDataMon();
        }
    }
}
