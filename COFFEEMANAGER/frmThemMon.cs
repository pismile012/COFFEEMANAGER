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
using COFFEEMANAGER.DAO;

namespace COFFEEMANAGER
{
    public partial class frmThemMon : Form
    {
        public frmThemMon()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            QLMon quanly = new QLMon();
            dt = quanly.LoatDataDanhmuc();
            cbThem_Madm.DataSource = dt;
            cbThem_Madm.DisplayMember = "madm";
        }

        private void btnThem_monmoi_Click(object sender, EventArgs e)
        {
            try
            {
                Mon mon = new Mon();
                mon.Mamon = txtThem_Mamon.Text.ToString();
                mon.Tenmon = txtThem_Tenmon.Text.ToString();
                mon.Gia = float.Parse(txtThem_Gia.Text.ToString());
                mon.Madm = cbThem_Madm.Text.ToString();

                QLMon quanly = new QLMon();
                int kq = quanly.ThemMon(mon);
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
