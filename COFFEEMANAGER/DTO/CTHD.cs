using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace COFFEEMANAGER.DTO
{
    public class CTHD
    {
        public CTHD(string mahd, string tenmon, string status, float gia = 0, int soluong =0, float thanhtien=0)
        {
            this.MAHD = mahd;
            this.TENMON = tenmon;
            this.GIA = gia;
            this.THANHTIEN = thanhtien;
            this.SOLUONNG = soluong;
            this.TRANGTHAI = status;

        }
        public CTHD(DataRow row)
        {
            this.MAHD = row["MAHD"].ToString();
            this.TENMON = row["TENMON"].ToString();
            this.GIA = float.Parse(row["GIA"].ToString());
            this.SOLUONNG = int.Parse(row["SOLUONG"].ToString());
            this.THANHTIEN = float.Parse(row["THANHTIEN"].ToString());
            this.TRANGTHAI = row["TRANGTHAI"].ToString();
        }
        //(ct.MAHD), m.MAMON,m.MADM, m.TENMON, m.GIA, ct.SOLUONG, hd.TRANGTHAI

        private string _mahd, _trangthai, _tenmon;
        private float _gia, _thanhtien;
        private int _soluong;
        public string MAHD { get => _mahd; set => _mahd = value; }
        public string TENMON { get => _tenmon; set => _tenmon = value; }
        public string TRANGTHAI { get => _trangthai; set => _trangthai = value; }
        public float GIA { get => _gia; set => _gia = value; }
        public float THANHTIEN { get => _thanhtien; set => _thanhtien = value; }
        public int SOLUONNG { get => _soluong; set => _soluong = value; }
    }
}
