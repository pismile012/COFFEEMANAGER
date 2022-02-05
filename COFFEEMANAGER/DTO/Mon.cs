using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFEEMANAGER.DTO
{
    public class Mon
    {
        private string _mamon, _tenmon, _madm;
        private float _gia;

        public string Mamon { get => _mamon; set => _mamon = value; }
        public string Tenmon { get => _tenmon; set => _tenmon = value; }
        public string Madm { get => _madm; set => _madm = value; }
        public float Gia { get => _gia; set => _gia = value; }
    }
}
