using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace COFFEEMANAGER.DTO
{
    public class DANHMUC
    {

        public DANHMUC(string madm, string tendm)
        {
            this.MADM = madm;
            this.TENDANHMUC = tendm;
           

        }
        public DANHMUC(DataRow row)
        {
            this.MADM = row["MADM"].ToString();
            this.TENDANHMUC= row["TENDM"].ToString();
        }

        private string _madm, _tendm;
        public string MADM { get => _madm; set => _madm = value; }

        public string TENDANHMUC { get => _tendm; set => _tendm = value; }

    }
}
