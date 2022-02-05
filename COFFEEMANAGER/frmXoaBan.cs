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
    public partial class frmXoaBan : Form
    {
        QLBan quanly = new QLBan();
        public frmXoaBan()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt = quanly.LoatDataBan();
            cbXoa_ban.DataSource = dt;
            cbXoa_ban.DisplayMember = "mach";
        }

        private void btnXoa_ban_Click(object sender, EventArgs e)
        {
            try
            {
                string machcanxoanxoa = cbXoa_ban.Text.ToString();
                int kq = quanly.XoaBan(machcanxoanxoa);
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

        private void cbXoa_ban_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
