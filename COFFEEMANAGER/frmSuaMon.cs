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
    public partial class frmSuaMon : Form
    {
        Admin frm1 = new Admin();
        QLMon quanly = new QLMon();
        public frmSuaMon()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            dt = quanly.LoatDataMon();
            cbSua_Mamon.DataSource = dt;
            cbSua_Mamon.DisplayMember = "mamon";
            dt1 = quanly.LoatDataDanhmuc();
            cbSua_Madm.DataSource = dt1;
            cbSua_Madm.DisplayMember = "madm";
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
