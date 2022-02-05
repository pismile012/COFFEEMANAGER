using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace COFFEEMANAGER.DTO
{
    public class MONDANHMUC
    {

        public MONDANHMUC(string mamon, string tenmon)
        {
            this.MAMON = mamon;
            this.TENMON = tenmon;
           

        }
        public MONDANHMUC(DataRow row)
        {
            this.MAMON = row["MAMON"].ToString();
            this.TENMON= row["TENMON"].ToString();
        }

        private string _mamon, _tenmon;
        public string MAMON { get => _mamon; set => _mamon = value; }

        public string TENMON { get => _tenmon; set => _tenmon = value; }

    }
}
