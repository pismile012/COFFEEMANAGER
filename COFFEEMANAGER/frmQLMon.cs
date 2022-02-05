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
    public partial class frmQLMon : Form
    {
        public Mon RowSelected;
        public frmQLMon()
        {
            InitializeComponent();
        }

        private void frmQLMon_Load(object sender, EventArgs e)
        {
            try
            {
                string tenmon = txtTimkiemMon.Text.ToString();
                QLMon quanly = new QLMon();
                DataTable dt = quanly.TimKiemMonTheoTen(tenmon);

                if (dt != null && dt.Rows.Count > 0)
                {
                    dataGV.DataSource = dt;

                }
                else
                {
                    MessageBox.Show("Mon khong ton tai !!! ");
                }
                if (dt.Rows.Count > 0)
                {

                    dataGV.Rows[0].Selected = true;
                    RowSelected = new Mon();
                    RowSelected.Mamon = dataGV.SelectedRows[0].Cells["colMamon"].Value.ToString();
                    RowSelected.Tenmon = dataGV.SelectedRows[0].Cells["colTenmon"].Value.ToString();
                    RowSelected.Gia = float.Parse(dataGV.SelectedRows[0].Cells["colGia"].Value.ToString());
                    RowSelected.Madm = dataGV.SelectedRows[0].Cells["colMadm"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
    }
}
