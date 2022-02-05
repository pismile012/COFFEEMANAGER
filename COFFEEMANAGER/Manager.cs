using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COFFEEMANAGER.DAO;
using COFFEEMANAGER.DTO;
using COFFEEMANAGER.BUS;
using System.Globalization;

namespace COFFEEMANAGER
{
    public partial class Manager : Form
    {
        private Account loginaccount;
        public Account Loginaccount
        {
            get { return loginaccount; }
            set { loginaccount = value; changeaccount(loginaccount.Type); }
        }
        public Manager()
        {
            InitializeComponent();
        }
        void changeaccount(string QUYEN)
        {
            aDMINToolStripMenuItem.Enabled = QUYEN == "admin";
        }
        private void aDMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin fr = new Admin();
            fr.ShowDialog();
        }

        private void thôngTinTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login fr = new Login();
            fr.Show();
        }
        void loadmahd(ComboBox cb)
        {
            List<MAHOADON> listCTHD = HOADONDAO.Instance.GetListMaHd();
            cbmahoadon.DataSource = listCTHD;
            cb.DisplayMember = "MAHD";
        }
        void loaddanhmuc()
        {
            List<DANHMUC> listCTHD = DANHMUCDAO.Instance.GetListDanhMuc();
            cbdanhmuc.DataSource = listCTHD;
            cbdanhmuc.DisplayMember = "TENDANHMUC";
        }
        void loadmon(string madm )
        {
            List<MONDANHMUC> listCTHD = MONDANHMUCDAO.Instance.GetListMon( madm);
            cbmon.DataSource = listCTHD;
            cbmon.DisplayMember = "TENMON";
        }
      
 
        void showhoadon(string macthd)
        {
            chitietHoadon.Items.Clear();
            
           /* macthd = cbmahoadon.SelectedItem.ToString();*/
            float totalPrice = 0;
            List<CTHD> hoadon = CTHDDAO.Instance.GetHoaDon(macthd);
            foreach (CTHD item in hoadon)
            {
                ListViewItem listView = new ListViewItem(item.TENMON.ToString());
                listView.SubItems.Add(item.GIA.ToString());
                listView.SubItems.Add(item.SOLUONNG.ToString());
                listView.SubItems.Add(item.THANHTIEN.ToString());
                totalPrice += item.THANHTIEN;
                listView.SubItems.Add(item.TRANGTHAI.ToString());
                listView.SubItems.Add(item.MAHD.ToString());
                chitietHoadon.Items.Add(listView);
            }
            txttotalPrice.Text = totalPrice.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateBill createBill = new CreateBill();
            createBill.Show();
       }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                HOADON hoadon = new HOADON();
                MAHOADON selected = cbmahoadon.SelectedItem as MAHOADON;
                hoadon.MAHD = selected.MAHD;
                
                HOADONBUS quanlyhoadon = new HOADONBUS();
                int kq = quanlyhoadon.ThanhToan(hoadon);
                if (kq > 0)
                {
                    showhoadon(hoadon.MAHD);
                    MessageBox.Show("Bạn đã thanh toán thành công hoá đơn " +hoadon.MAHD+ " Cảm ơn bạn đã ghé cửa hàng");

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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
         

            try
            {
                string mahd = null;
                MAHOADON selected = cbmahoadon.SelectedItem as MAHOADON;
                mahd = selected.MAHD;

                CTHDBUS quanlyhoadon = new CTHDBUS();
                int kq = quanlyhoadon.Delete(mahd);
                if (kq > 0)
                {
                    MessageBox.Show("Bạn đã xoá thành công hoá đơn" + mahd +" !!!");
                    showhoadon(mahd);
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

        private void thongtinkhuvuc_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Manager_Load(object sender, EventArgs e)
        {
            loadmahd(cbmahoadon);
            loaddanhmuc();
        }

        private void cbmahoadon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cthd = null;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
            {
                return;
            }
            MAHOADON selected = cb.SelectedItem as MAHOADON;
            cthd = selected.MAHD;
            showhoadon(cthd);
        }

        private void cbmahoadon_Click(object sender, EventArgs e)
        {
          
        }

        private void cbdanhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string madanhmuc = null;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
            {
                return;
            }
            DANHMUC selected = cb.SelectedItem as DANHMUC;
            madanhmuc = selected.MADM;
            loadmon(madanhmuc);
        }
    }
}
