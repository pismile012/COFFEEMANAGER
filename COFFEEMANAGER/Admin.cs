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
    public partial class Admin : Form
    {
        public Mon RowSelected_Food;
        public Account RowSelected_Account;
        private Ban rowSelected_Ban;
        internal Ban RowSelected_Ban { get => rowSelected_Ban; set => rowSelected_Ban = value; }
        BindingSource accountList = new BindingSource();
        public Admin()
        {
            InitializeComponent();
            LoadDataAccount();
            LoadDataMon();
            LoadDataBan();
            LoadHoaDon();
        }
        void LoadDataAccount()
        {
            dgvAccount.DataSource = accountList;
            LoadAccount();
            AddAccountBinding();
        }
        void LoadDataMon()
        {
            try
            {
                QLMon quanly = new QLMon();
                DataTable dt = quanly.LoatDataMon();

                if (dt != null && dt.Rows.Count > 0)
                {
                    dataGVMon.DataSource = dt;
                }

                if (dt.Rows.Count > 0)
                {

                    dataGVMon.Rows[0].Selected = true;
                    RowSelected_Food = new Mon();
                    RowSelected_Food.Mamon = dataGVMon.SelectedRows[0].Cells["colMamon"].Value.ToString();
                    RowSelected_Food.Tenmon = dataGVMon.SelectedRows[0].Cells["colTenmon"].Value.ToString();
                    RowSelected_Food.Gia = float.Parse(dataGVMon.SelectedRows[0].Cells["colGia"].Value.ToString());
                    RowSelected_Food.Madm = dataGVMon.SelectedRows[0].Cells["colMadm"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
        void LoadDataBan()
        {
            try
            {
                QLBan quanly = new QLBan();
                DataTable dt = quanly.LoatDataBan();

                if (dt != null && dt.Rows.Count > 0)
                {
                    dgvBan.DataSource = dt;
                }

                if (dt.Rows.Count > 0)
                {

                    dgvBan.Rows[0].Selected = true;
                    RowSelected_Ban = new Ban();
                    RowSelected_Ban.Mach = dgvBan.SelectedRows[0].Cells["colMach"].Value.ToString();
                    RowSelected_Ban.Mamon = dgvBan.SelectedRows[0].Cells["dataGridViewTextBoxColumn1"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
        /// <summary>
        /// Quan ly DANG NHAP + TAI KHOAN
        /// </summary>
        void AddAccountBinding()
        {
            txtTk.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "TENTK", true, DataSourceUpdateMode.Never));
            txtMk.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "MATKHAU", true, DataSourceUpdateMode.Never));
            ckbType.DataBindings.Add(new Binding("Checked", dgvAccount.DataSource, "QUYEN", true, DataSourceUpdateMode.Never));
        }
        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.LoadAccount();
        }
        void AddAccount(string username, string password,string type)
        {
            if (AccountDAO.Instance.AddAccount(username, password, type))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }

            LoadAccount();
        }
        void UpdateAccount(string username, string password, string type)
        {
            if (AccountDAO.Instance.UpAccount(username, password, type))
            {
                MessageBox.Show("Sua tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Sua tài khoản thất bại");
            }
            
            LoadAccount();
        }
        void DeleteAccount(string username)
        {
            if (AccountDAO.Instance.DelAccount(username))
            {
                MessageBox.Show("Xoa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xoa tài khoản thất bại");
            }

            LoadAccount();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string username = txtTk.Text;
            string password = txtMk.Text;
            string type = "";
            if (ckbType.Checked)
            {
                type = "admin";
            }
            else
            {
                type = "staff";
            }
            AddAccount(username, password, type);
        }

        private void btnUp_Click_1(object sender, EventArgs e)
        {
            string username = txtTk.Text;
            string password = txtMk.Text;
            string type = "";
            if (ckbType.Checked)
            {
                type = "admin";
            }
            else
            {
                type = "staff";
            }
            UpdateAccount(username, password, type);
        }

        private void btnDel_Click_1(object sender, EventArgs e)
        {
            string username = txtTk.Text;
            DeleteAccount(username);
        }
        /// <summary>
        /// Quan ly MON AN
        /// </summary>
        private void btnTimkiem_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemMon them = new frmThemMon();
            them.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            frmXoaMon xoa = new frmXoaMon();
            xoa.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmSuaMon fr = new frmSuaMon();
            fr.Show();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadDataMon();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Quan ly CUA HANG + BAN
        /// </summary>

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_timkiem_Click(object sender, EventArgs e)
        {
            try
            {
                string tenmon = txtTimkiemBan.Text.ToString();
                QLBan quanly = new QLBan();
                DataTable dt = quanly.TimKiemBanTheoTen(tenmon);

                if (dt != null && dt.Rows.Count > 0)
                {
                    dataGVMon.DataSource = dt;

                }
                else
                {
                    MessageBox.Show("Mon khong ton tai !!! ");
                }
                if (dt.Rows.Count > 0)
                {

                    dataGVMon.Rows[0].Selected = true;
                    RowSelected_Ban = new Ban();
                    RowSelected_Ban.Mach = dgvBan.SelectedRows[0].Cells["colMamon"].Value.ToString();
                    RowSelected_Ban.Mamon = dgvBan.SelectedRows[0].Cells["colTenmon"].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            frmThemBan them = new frmThemBan();
            them.Show();
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            frmXoaBan xoa = new frmXoaBan();
            xoa.Show();
        }

        private void button_loaddata_Click(object sender, EventArgs e)
        {
            LoadDataBan();
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Quan ly THONG KE
        /// </summary>


        public HOADON RowSelected_HOADON;
        void LoadHoaDon()
        {


            try
            {

                HOADONBUS ql = new HOADONBUS();
                DataTable dt = ql.getallhoadon();

                if (dt != null && dt.Rows.Count > 0)
                {
                    dgvHD.DataSource = dt;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
        void SearchHoaDon()
        {
            try
            {
                string mach = null;
                DateTime date = DateTime.Now;
                string status = null;
                mach = cbMach.SelectedItem.ToString();
                date = dtpicker.Value;
                string datecheckout = Convert.ToDateTime(date).ToString("dd/MM/yyyy");
                status = cbstatus.SelectedItem.ToString();
                HOADONBUS ql = new HOADONBUS();
                DataTable dt = ql.SearchHoaDon(mach, datecheckout, status);

                if (dt != null && dt.Rows.Count > 0)
                {
                    dgvHD.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu thống kê !!! ");
                }
                if (dt.Rows.Count > 0)
                {

                    dgvHD.Rows[0].Selected = true;
                    RowSelected_HOADON = new HOADON();
                    RowSelected_HOADON.MACH = dgvHD.SelectedRows[0].Cells["colmach"].Value.ToString();
                    RowSelected_HOADON.TONGTIEN = float.Parse(dgvHD.SelectedRows[0].Cells["coltongtien"].Value.ToString());
                    RowSelected_HOADON.CHECKOUT = Convert.ToDateTime(dgvHD.SelectedRows[0].Cells["colcheckout"].Value.ToString());
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
        private void btnThongke_Click(object sender, EventArgs e)
        {
            SearchHoaDon();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
