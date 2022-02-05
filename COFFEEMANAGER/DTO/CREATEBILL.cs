using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace COFFEEMANAGER.DTO
{
    public class CREATEBILL
    {

        private string _mahd, _trangthai, _mamon;
        private int _soluong;
        public string MAHD { get => _mahd; set => _mahd = value; }
        public string MAMON { get => _mamon; set => _mamon = value; }
        public string TRANGTHAI { get => _trangthai; set => _trangthai = value; }
        public int SOLUONG { get => _soluong; set => _soluong = value; }
    }
}
