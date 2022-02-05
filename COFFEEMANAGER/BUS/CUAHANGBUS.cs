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
    public class CUAHANGBUS
    {
        public List<DTO.CUAHANG> GetListCuaHang()
        {
            CUAHANGDAO dao = new CUAHANGDAO();
            return dao.GetListCuaHang();
        }
    }
}
