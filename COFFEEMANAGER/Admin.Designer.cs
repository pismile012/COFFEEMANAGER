
namespace COFFEEMANAGER
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ckbType = new System.Windows.Forms.CheckBox();
            this.txtMk = new System.Windows.Forms.TextBox();
            this.txtTk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGVMon = new System.Windows.Forms.DataGridView();
            this.colMamon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenmon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMadm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtTimkiemMon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvBan = new System.Windows.Forms.DataGridView();
            this.ColMach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTimkiemBan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_thoat = new System.Windows.Forms.Button();
            this.button_loaddata = new System.Windows.Forms.Button();
            this.button_timkiem = new System.Windows.Forms.Button();
            this.button_xoa = new System.Windows.Forms.Button();
            this.button_them = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cbstatus = new System.Windows.Forms.ComboBox();
            this.cbMach = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpicker = new System.Windows.Forms.DateTimePicker();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcheckout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThongke = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVMon)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(602, 385);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDel);
            this.tabPage1.Controls.Add(this.btnUp);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.ckbType);
            this.tabPage1.Controls.Add(this.txtMk);
            this.tabPage1.Controls.Add(this.txtTk);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgvAccount);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(594, 359);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Account Manager";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(314, 82);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 23;
            this.btnDel.Text = "Xoa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click_1);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(314, 53);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 22;
            this.btnUp.Text = "Sua";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(314, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Them";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // ckbType
            // 
            this.ckbType.AutoSize = true;
            this.ckbType.Location = new System.Drawing.Point(69, 80);
            this.ckbType.Name = "ckbType";
            this.ckbType.Size = new System.Drawing.Size(55, 17);
            this.ckbType.TabIndex = 20;
            this.ckbType.Text = "Admin";
            this.ckbType.UseVisualStyleBackColor = true;
            // 
            // txtMk
            // 
            this.txtMk.Location = new System.Drawing.Point(69, 50);
            this.txtMk.Name = "txtMk";
            this.txtMk.Size = new System.Drawing.Size(100, 20);
            this.txtMk.TabIndex = 19;
            // 
            // txtTk
            // 
            this.txtTk.Location = new System.Drawing.Point(69, 21);
            this.txtTk.Name = "txtTk";
            this.txtTk.Size = new System.Drawing.Size(100, 20);
            this.txtTk.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Quyen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mat Khau";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ten TK";
            // 
            // dgvAccount
            // 
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(13, 176);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.Size = new System.Drawing.Size(457, 112);
            this.dgvAccount.TabIndex = 14;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGVMon);
            this.tabPage2.Controls.Add(this.btnThoat);
            this.tabPage2.Controls.Add(this.btnLoad);
            this.tabPage2.Controls.Add(this.btnSua);
            this.tabPage2.Controls.Add(this.btnXoa);
            this.tabPage2.Controls.Add(this.btnThem);
            this.tabPage2.Controls.Add(this.btnTimkiem);
            this.tabPage2.Controls.Add(this.txtTimkiemMon);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(594, 359);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Food Manager";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGVMon
            // 
            this.dataGVMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMamon,
            this.colTenmon,
            this.colGia,
            this.colMadm});
            this.dataGVMon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGVMon.Location = new System.Drawing.Point(3, 72);
            this.dataGVMon.Margin = new System.Windows.Forms.Padding(2);
            this.dataGVMon.Name = "dataGVMon";
            this.dataGVMon.RowHeadersWidth = 51;
            this.dataGVMon.RowTemplate.Height = 24;
            this.dataGVMon.Size = new System.Drawing.Size(588, 284);
            this.dataGVMon.TabIndex = 13;
            // 
            // colMamon
            // 
            this.colMamon.DataPropertyName = "mamon";
            this.colMamon.HeaderText = "Mã món";
            this.colMamon.MinimumWidth = 6;
            this.colMamon.Name = "colMamon";
            this.colMamon.Width = 125;
            // 
            // colTenmon
            // 
            this.colTenmon.DataPropertyName = "tenmon";
            this.colTenmon.HeaderText = "Tên Món";
            this.colTenmon.MinimumWidth = 6;
            this.colTenmon.Name = "colTenmon";
            this.colTenmon.Width = 150;
            // 
            // colGia
            // 
            this.colGia.DataPropertyName = "gia";
            this.colGia.HeaderText = "Gía";
            this.colGia.MinimumWidth = 6;
            this.colGia.Name = "colGia";
            this.colGia.Width = 125;
            // 
            // colMadm
            // 
            this.colMadm.DataPropertyName = "madm";
            this.colMadm.HeaderText = "Mã danh mục";
            this.colMadm.MinimumWidth = 6;
            this.colMadm.Name = "colMadm";
            this.colMadm.Width = 125;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(418, 35);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(84, 19);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(321, 35);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(84, 19);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Load data";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(213, 35);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(84, 19);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa Món";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(108, 35);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 19);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa Món";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 35);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 19);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm Món";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(284, 4);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(78, 19);
            this.btnTimkiem.TabIndex = 7;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtTimkiemMon
            // 
            this.txtTimkiemMon.Location = new System.Drawing.Point(100, 4);
            this.txtTimkiemMon.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimkiemMon.Name = "txtTimkiemMon";
            this.txtTimkiemMon.Size = new System.Drawing.Size(155, 20);
            this.txtTimkiemMon.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên món cần tìm";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(594, 359);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Store Manager";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvBan);
            this.groupBox2.Location = new System.Drawing.Point(17, 194);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(561, 150);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox1";
            // 
            // dgvBan
            // 
            this.dgvBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMach,
            this.dataGridViewTextBoxColumn1});
            this.dgvBan.Location = new System.Drawing.Point(11, 16);
            this.dgvBan.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBan.Name = "dgvBan";
            this.dgvBan.RowHeadersWidth = 62;
            this.dgvBan.RowTemplate.Height = 28;
            this.dgvBan.Size = new System.Drawing.Size(525, 117);
            this.dgvBan.TabIndex = 0;
            // 
            // ColMach
            // 
            this.ColMach.DataPropertyName = "mach";
            this.ColMach.HeaderText = "Mã cửa hàng";
            this.ColMach.MinimumWidth = 8;
            this.ColMach.Name = "ColMach";
            this.ColMach.Width = 450;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "mamon";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã món";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 450;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTimkiemBan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button_thoat);
            this.groupBox1.Controls.Add(this.button_loaddata);
            this.groupBox1.Controls.Add(this.button_timkiem);
            this.groupBox1.Controls.Add(this.button_xoa);
            this.groupBox1.Controls.Add(this.button_them);
            this.groupBox1.Location = new System.Drawing.Point(17, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(561, 153);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtTimkiemBan
            // 
            this.txtTimkiemBan.Location = new System.Drawing.Point(135, 29);
            this.txtTimkiemBan.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimkiemBan.Name = "txtTimkiemBan";
            this.txtTimkiemBan.Size = new System.Drawing.Size(129, 20);
            this.txtTimkiemBan.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "tìm kiếm mã cửa hàng";
            // 
            // button_thoat
            // 
            this.button_thoat.Location = new System.Drawing.Point(457, 72);
            this.button_thoat.Margin = new System.Windows.Forms.Padding(2);
            this.button_thoat.Name = "button_thoat";
            this.button_thoat.Size = new System.Drawing.Size(60, 29);
            this.button_thoat.TabIndex = 0;
            this.button_thoat.Text = "thoát";
            this.button_thoat.UseVisualStyleBackColor = true;
            this.button_thoat.Click += new System.EventHandler(this.button_thoat_Click);
            // 
            // button_loaddata
            // 
            this.button_loaddata.Location = new System.Drawing.Point(370, 72);
            this.button_loaddata.Margin = new System.Windows.Forms.Padding(2);
            this.button_loaddata.Name = "button_loaddata";
            this.button_loaddata.Size = new System.Drawing.Size(60, 29);
            this.button_loaddata.TabIndex = 0;
            this.button_loaddata.Text = "load data";
            this.button_loaddata.UseVisualStyleBackColor = true;
            this.button_loaddata.Click += new System.EventHandler(this.button_loaddata_Click);
            // 
            // button_timkiem
            // 
            this.button_timkiem.Location = new System.Drawing.Point(292, 21);
            this.button_timkiem.Margin = new System.Windows.Forms.Padding(2);
            this.button_timkiem.Name = "button_timkiem";
            this.button_timkiem.Size = new System.Drawing.Size(60, 29);
            this.button_timkiem.TabIndex = 0;
            this.button_timkiem.Text = "tìm kiếm";
            this.button_timkiem.UseVisualStyleBackColor = true;
            this.button_timkiem.Click += new System.EventHandler(this.button_timkiem_Click);
            // 
            // button_xoa
            // 
            this.button_xoa.Location = new System.Drawing.Point(283, 72);
            this.button_xoa.Margin = new System.Windows.Forms.Padding(2);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(60, 29);
            this.button_xoa.TabIndex = 0;
            this.button_xoa.Text = "xóa";
            this.button_xoa.UseVisualStyleBackColor = true;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // button_them
            // 
            this.button_them.Location = new System.Drawing.Point(202, 72);
            this.button_them.Margin = new System.Windows.Forms.Padding(2);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(60, 29);
            this.button_them.TabIndex = 0;
            this.button_them.Text = "thêm";
            this.button_them.UseVisualStyleBackColor = true;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cbstatus);
            this.tabPage4.Controls.Add(this.cbMach);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.dtpicker);
            this.tabPage4.Controls.Add(this.dgvHD);
            this.tabPage4.Controls.Add(this.btnThongke);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(594, 359);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Statistics";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cbstatus
            // 
            this.cbstatus.FormattingEnabled = true;
            this.cbstatus.Items.AddRange(new object[] {
            "đã thanh toán",
            "chưa thanh toán"});
            this.cbstatus.Location = new System.Drawing.Point(103, 73);
            this.cbstatus.Name = "cbstatus";
            this.cbstatus.Size = new System.Drawing.Size(200, 21);
            this.cbstatus.TabIndex = 29;
            // 
            // cbMach
            // 
            this.cbMach.FormattingEnabled = true;
            this.cbMach.Items.AddRange(new object[] {
            "CH001",
            "CH002",
            "CH003",
            "CH004",
            "CH005",
            "CH006",
            "CH007",
            "CH008",
            "CH009",
            "CH010"});
            this.cbMach.Location = new System.Drawing.Point(103, 7);
            this.cbMach.Name = "cbMach";
            this.cbMach.Size = new System.Drawing.Size(200, 21);
            this.cbMach.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Thoat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Danh Sách Hoá Đơn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Trạng Thái";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Mã Cửa Hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Check Out";
            // 
            // dtpicker
            // 
            this.dtpicker.CustomFormat = "dd/MM/yyyy";
            this.dtpicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpicker.Location = new System.Drawing.Point(103, 41);
            this.dtpicker.Name = "dtpicker";
            this.dtpicker.Size = new System.Drawing.Size(200, 20);
            this.dtpicker.TabIndex = 23;
            this.dtpicker.Value = new System.DateTime(2022, 1, 6, 7, 50, 26, 0);
            // 
            // dgvHD
            // 
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.coltongtien,
            this.colcheckout});
            this.dgvHD.Location = new System.Drawing.Point(17, 174);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.Size = new System.Drawing.Size(345, 179);
            this.dgvHD.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MACH";
            this.dataGridViewTextBoxColumn2.HeaderText = "MÃ CH";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // coltongtien
            // 
            this.coltongtien.DataPropertyName = "TONGTIEN";
            this.coltongtien.HeaderText = "TỔNG TIỀN";
            this.coltongtien.Name = "coltongtien";
            // 
            // colcheckout
            // 
            this.colcheckout.DataPropertyName = "CHECKOUT";
            this.colcheckout.HeaderText = "NGÀY XUẤT";
            this.colcheckout.Name = "colcheckout";
            // 
            // btnThongke
            // 
            this.btnThongke.Location = new System.Drawing.Point(103, 111);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(65, 23);
            this.btnThongke.TabIndex = 21;
            this.btnThongke.Text = "Thống Kê";
            this.btnThongke.UseVisualStyleBackColor = true;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 409);
            this.Controls.Add(this.tabControl1);
            this.Name = "Admin";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVMon)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox ckbType;
        private System.Windows.Forms.TextBox txtMk;
        private System.Windows.Forms.TextBox txtTk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.DataGridView dataGVMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMamon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenmon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMadm;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtTimkiemMon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMach;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTimkiemBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_thoat;
        private System.Windows.Forms.Button button_loaddata;
        private System.Windows.Forms.Button button_timkiem;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox cbstatus;
        private System.Windows.Forms.ComboBox cbMach;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpicker;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcheckout;
        private System.Windows.Forms.Button btnThongke;
    }
}