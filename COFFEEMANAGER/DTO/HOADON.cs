using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace COFFEEMANAGER.DTO
{
    public class  HOADON
    {

        private string _mahd, _ngayxuat, _trangthai, _sdt, _mach, _manv;
        private DateTime _checkout;
        private float _tongtien;
        public string MAHD { get => _mahd; set => _mahd = value; }
        public string NGAYXUAT { get => _ngayxuat; set => _ngayxuat = value; }
        public DateTime CHECKOUT { get => _checkout; set => _checkout = value; }
        public string TRANGTHAI { get => _trangthai; set => _trangthai = value; }
        public string SDT { get => _sdt; set => _sdt = value; }
        public string MACH { get => _mach; set => _mach = value; }
        public string MANV { get => _manv; set => _manv = value; }
        public float TONGTIEN { get => _tongtien; set => _tongtien = value; }
    }
}
