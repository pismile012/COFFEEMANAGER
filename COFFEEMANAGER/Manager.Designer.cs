
namespace COFFEEMANAGER
{
    partial class Manager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aDMINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTaiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.thongtinkhuvuc = new System.Windows.Forms.GroupBox();
            this.chitietHoadon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbmahoadon = new System.Windows.Forms.ComboBox();
            this.txttotalPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbdanhmuc = new System.Windows.Forms.ComboBox();
            this.cbmon = new System.Windows.Forms.ComboBox();
            this.soluong = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.thongtinkhuvuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDMINToolStripMenuItem,
            this.thôngTinTaiKhoanToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(616, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aDMINToolStripMenuItem
            // 
            this.aDMINToolStripMenuItem.Name = "aDMINToolStripMenuItem";
            this.aDMINToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.aDMINToolStripMenuItem.Text = "ADMIN";
            this.aDMINToolStripMenuItem.Click += new System.EventHandler(this.aDMINToolStripMenuItem_Click);
            // 
            // thôngTinTaiKhoanToolStripMenuItem
            // 
            this.thôngTinTaiKhoanToolStripMenuItem.Name = "thôngTinTaiKhoanToolStripMenuItem";
            this.thôngTinTaiKhoanToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.thôngTinTaiKhoanToolStripMenuItem.Text = "Thông Tin Tài Khoản";
            this.thôngTinTaiKhoanToolStripMenuItem.Click += new System.EventHandler(this.thôngTinTaiKhoanToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã HD";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(367, 89);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Thanh Toán";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(269, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Huỷ Đơn";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Tạo Hoá Đơn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // thongtinkhuvuc
            // 
            this.thongtinkhuvuc.Controls.Add(this.chitietHoadon);
            this.thongtinkhuvuc.Location = new System.Drawing.Point(8, 118);
            this.thongtinkhuvuc.Name = "thongtinkhuvuc";
            this.thongtinkhuvuc.Size = new System.Drawing.Size(603, 233);
            this.thongtinkhuvuc.TabIndex = 7;
            this.thongtinkhuvuc.TabStop = false;
            this.thongtinkhuvuc.Text = "Thông Tin Bàn";
            this.thongtinkhuvuc.Enter += new System.EventHandler(this.thongtinkhuvuc_Enter);
            // 
            // chitietHoadon
            // 
            this.chitietHoadon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.chitietHoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chitietHoadon.GridLines = true;
            this.chitietHoadon.HideSelection = false;
            this.chitietHoadon.Location = new System.Drawing.Point(3, 16);
            this.chitietHoadon.Name = "chitietHoadon";
            this.chitietHoadon.Size = new System.Drawing.Size(597, 214);
            this.chitietHoadon.TabIndex = 0;
            this.chitietHoadon.UseCompatibleStateImageBehavior = false;
            this.chitietHoadon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Món";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Đơn Giá";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số Lượng";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành Tiền";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Trạng Thái";
            this.columnHeader5.Width = 98;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mã Hoá Đơn";
            this.columnHeader6.Width = 90;
            // 
            // cbmahoadon
            // 
            this.cbmahoadon.FormattingEnabled = true;
            this.cbmahoadon.Location = new System.Drawing.Point(8, 62);
            this.cbmahoadon.Name = "cbmahoadon";
            this.cbmahoadon.Size = new System.Drawing.Size(145, 21);
            this.cbmahoadon.TabIndex = 6;
            this.cbmahoadon.SelectedIndexChanged += new System.EventHandler(this.cbmahoadon_SelectedIndexChanged);
            this.cbmahoadon.Click += new System.EventHandler(this.cbmahoadon_Click);
            // 
            // txttotalPrice
            // 
            this.txttotalPrice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txttotalPrice.Location = new System.Drawing.Point(466, 86);
            this.txttotalPrice.Name = "txttotalPrice";
            this.txttotalPrice.ReadOnly = true;
            this.txttotalPrice.Size = new System.Drawing.Size(138, 26);
            this.txttotalPrice.TabIndex = 14;
            this.txttotalPrice.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã Danh Mục";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tên Món";
            // 
            // cbdanhmuc
            // 
            this.cbdanhmuc.FormattingEnabled = true;
            this.cbdanhmuc.Location = new System.Drawing.Point(160, 62);
            this.cbdanhmuc.Name = "cbdanhmuc";
            this.cbdanhmuc.Size = new System.Drawing.Size(157, 21);
            this.cbdanhmuc.TabIndex = 15;
            this.cbdanhmuc.SelectedIndexChanged += new System.EventHandler(this.cbdanhmuc_SelectedIndexChanged);
            // 
            // cbmon
            // 
            this.cbmon.FormattingEnabled = true;
            this.cbmon.Location = new System.Drawing.Point(323, 62);
            this.cbmon.Name = "cbmon";
            this.cbmon.Size = new System.Drawing.Size(137, 21);
            this.cbmon.TabIndex = 15;
            // 
            // soluong
            // 
            this.soluong.FormattingEnabled = true;
            this.soluong.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.soluong.Location = new System.Drawing.Point(466, 62);
            this.soluong.Name = "soluong";
            this.soluong.Size = new System.Drawing.Size(137, 21);
            this.soluong.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Số Lượng";
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 358);
            this.Controls.Add(this.soluong);
            this.Controls.Add(this.cbmon);
            this.Controls.Add(this.cbdanhmuc);
            this.Controls.Add(this.txttotalPrice);
            this.Controls.Add(this.thongtinkhuvuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbmahoadon);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Manager";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.thongtinkhuvuc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aDMINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTaiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox thongtinkhuvuc;
        private System.Windows.Forms.ComboBox cbmahoadon;
        private System.Windows.Forms.ListView chitietHoadon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox txttotalPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbdanhmuc;
        private System.Windows.Forms.ComboBox cbmon;
        private System.Windows.Forms.ComboBox soluong;
        private System.Windows.Forms.Label label4;
    }
}