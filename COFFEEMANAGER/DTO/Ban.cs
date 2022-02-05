using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFEEMANAGER.DTO
{
    public class Ban
    {
        private string _mach, _mamon;


        public string Mach { get => _mach; set => _mach = value; }
        public string Mamon { get => _mamon; set => _mamon = value; }
    }
}
