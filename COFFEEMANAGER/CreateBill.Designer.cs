
namespace COFFEEMANAGER
{
    partial class CreateBill
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
            this.btCreateBill = new System.Windows.Forms.Button();
            this.cbDanhMuc = new System.Windows.Forms.ComboBox();
            this.cbMon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MaHD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btCreateBill
            // 
            this.btCreateBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCreateBill.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreateBill.Location = new System.Drawing.Point(452, 184);
            this.btCreateBill.Name = "btCreateBill";
            this.btCreateBill.Size = new System.Drawing.Size(109, 41);
            this.btCreateBill.TabIndex = 0;
            this.btCreateBill.Text = "Tạo Hoá Đơn";
            this.btCreateBill.UseVisualStyleBackColor = true;
            this.btCreateBill.Click += new System.EventHandler(this.btCreateBill_Click);
            // 
            // cbDanhMuc
            // 
            this.cbDanhMuc.FormattingEnabled = true;
            this.cbDanhMuc.Location = new System.Drawing.Point(12, 35);
            this.cbDanhMuc.Name = "cbDanhMuc";
            this.cbDanhMuc.Size = new System.Drawing.Size(265, 21);
            this.cbDanhMuc.TabIndex = 1;
            this.cbDanhMuc.SelectedIndexChanged += new System.EventHandler(this.cbDanhMuc_SelectedIndexChanged);
            // 
            // cbMon
            // 
            this.cbMon.FormattingEnabled = true;
            this.cbMon.Location = new System.Drawing.Point(12, 87);
            this.cbMon.Name = "cbMon";
            this.cbMon.Size = new System.Drawing.Size(265, 21);
            this.cbMon.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh Mục";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Món";
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.Location = new System.Drawing.Point(296, 36);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.Size = new System.Drawing.Size(265, 20);
            this.tbSoLuong.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(293, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số Lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(293, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã Hoá Đơn";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // MaHD
            // 
            this.MaHD.Location = new System.Drawing.Point(296, 88);
            this.MaHD.Name = "MaHD";
            this.MaHD.Size = new System.Drawing.Size(265, 20);
            this.MaHD.TabIndex = 5;
            this.MaHD.Text = "HD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(293, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Trạng Thái";
            // 
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Đã Thanh Toán",
            "Chưa Thanh Toán"});
            this.status.Location = new System.Drawing.Point(296, 139);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(265, 21);
            this.status.TabIndex = 2;
            // 
            // CreateBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 240);
            this.Controls.Add(this.MaHD);
            this.Controls.Add(this.tbSoLuong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.cbMon);
            this.Controls.Add(this.cbDanhMuc);
            this.Controls.Add(this.btCreateBill);
            this.Name = "CreateBill";
            this.Text = "CreateBill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCreateBill;
        private System.Windows.Forms.ComboBox cbDanhMuc;
        private System.Windows.Forms.ComboBox cbMon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MaHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox status;
    }
}