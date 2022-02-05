using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace COFFEEMANAGER.DTO
{
    public class  MAHOADON
    {

        public MAHOADON(string mahd)
        {
            this.MAHD = mahd;
           

        }
        public MAHOADON(DataRow row)
        {
            this.MAHD = row["MAHD"].ToString();
        }

        private string _mahd;
        public string MAHD { get => _mahd; set => _mahd = value; }
   
    }
}
