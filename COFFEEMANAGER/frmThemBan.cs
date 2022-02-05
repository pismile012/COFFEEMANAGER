using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COFFEEMANAGER.BUS;
using COFFEEMANAGER.DTO;

namespace COFFEEMANAGER
{
    public partial class frmThemBan : Form
    {
        public frmThemBan()
        {
            InitializeComponent();
        }

        private void button_thembanmoi_Click(object sender, EventArgs e)
        {
            try
            {
                Ban ban = new Ban();
                ban.Mach = txtThem_Mach.Text.ToString();
                ban.Mamon = txtThem_Mamon.Text.ToString();


                QLBan quanly = new QLBan();
                int kq = quanly.ThemBan(ban);
                if (kq > 0)
                {
                    MessageBox.Show("Them thanh cong !");
                }
                else
                {
                    MessageBox.Show("Them that bai !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
    }
}
