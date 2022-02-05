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
    public partial class frmXoaMon : Form
    {
        QLMon quanly = new QLMon();
        public frmXoaMon()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt = quanly.LoatDataMon();
            cbXoa_mon.DataSource = dt;
            cbXoa_mon.DisplayMember = "mamon";
        }

        private void btnXoa_mon_Click(object sender, EventArgs e)
        {
            try
            {
                string mamoncanxoanxoa = cbXoa_mon.Text.ToString();
                int kq = quanly.XoaMon(mamoncanxoanxoa);
                if (kq > 0)
                {
                    MessageBox.Show("Xoa thanh cong !");
                }
                else
                {
                    MessageBox.Show("Xoa that bai !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
    }
}
