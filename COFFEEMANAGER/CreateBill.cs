using COFFEEMANAGER.BUS;
using COFFEEMANAGER.DAO;
using COFFEEMANAGER.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COFFEEMANAGER
{
    public partial class CreateBill : Form
    {
        public CreateBill()
        {
            InitializeComponent();
            loaddanhmuc();
        }
        void loaddanhmuc()
        {
            List<DANHMUC> listCTHD = DANHMUCDAO.Instance.GetListDanhMuc();
            cbDanhMuc.DataSource = listCTHD;
            cbDanhMuc.DisplayMember = "TENDANHMUC";
        }
        void loadmon(string madm)
        {
            List<MONDANHMUC> listCTHD = MONDANHMUCDAO.Instance.GetListMon(madm);
            cbMon.DataSource = listCTHD;
            cbMon.DisplayMember = "TENMON";
        }
        

        private void cbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
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

      

        private void btCreateBill_Click(object sender, EventArgs e)
        {
            try
            {
                MONDANHMUC selected = cbMon.SelectedItem as MONDANHMUC;
                CREATEBILL bill = new CREATEBILL();
                bill.MAMON = selected.MAMON;
                bill.MAHD = MaHD.Text.ToString();
                bill.SOLUONG = int.Parse(tbSoLuong.Text.ToString());
                bill.TRANGTHAI = status.SelectedItem.ToString();

                CTHDBUS quanly = new CTHDBUS();
                int kq = quanly.CreateBillBus(bill);
                if (kq > 0)
                {
                   
                    MessageBox.Show("Them thanh cong !");
                    this.Hide();
                    Manager manager = new Manager();
                    manager.Show();
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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
