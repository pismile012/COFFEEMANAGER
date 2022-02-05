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
    public partial class frmSua : Form
    {
        frmQLMon frm1 = new frmQLMon();
        QLMon quanly = new QLMon();
        public frmSua()
        {
            InitializeComponent();
        }

        private void btnSua_mon_Click(object sender, EventArgs e)
        {
            try
            {
                Mon mon = new Mon();
                mon.Mamon = cbSua_Mamon.Text.ToString();
                mon.Tenmon = txtSua_Tenmon.Text.ToString();
                mon.Gia = float.Parse(txtSua_Gia.Text.ToString());
                mon.Madm = cbSua_Madm.Text.ToString();


                int kq = quanly.SuaMon(mon);
                if (kq > 0)
                {
                    MessageBox.Show("Cap nhat thanh cong !");
                    frm1.LoadData();
                    frm1.Show();
                }
                else
                {
                    MessageBox.Show("Cap nhat that bai !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
    }
}
