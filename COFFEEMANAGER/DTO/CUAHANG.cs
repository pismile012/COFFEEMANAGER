using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace COFFEEMANAGER.DTO
{
    public class CUAHANG
    {
        public CUAHANG(string mach)
        {
            this.MACH = mach;
        }
        public CUAHANG(DataRow row)
        {
            this.MACH = row["MACH"].ToString();
        }

        private string _mach;
        public string MACH { get => _mach; set => _mach = value; }
    }
}
