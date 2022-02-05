
namespace COFFEEMANAGER
{
    partial class frmQLMon
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
            this.dataGV = new System.Windows.Forms.DataGridView();
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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGV
            // 
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMamon,
            this.colTenmon,
            this.colGia,
            this.colMadm});
            this.dataGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGV.Location = new System.Drawing.Point(0, 89);
            this.dataGV.Margin = new System.Windows.Forms.Padding(2);
            this.dataGV.Name = "dataGV";
            this.dataGV.RowHeadersWidth = 51;
            this.dataGV.RowTemplate.Height = 24;
            this.dataGV.Size = new System.Drawing.Size(547, 284);
            this.dataGV.TabIndex = 13;
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
            this.btnThoat.Location = new System.Drawing.Point(418, 34);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(84, 19);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(321, 34);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(84, 19);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Load data";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(213, 34);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(84, 19);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa Món";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(108, 34);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 19);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa Món";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 34);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 19);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm Món";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(284, 3);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(78, 19);
            this.btnTimkiem.TabIndex = 7;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // txtTimkiemMon
            // 
            this.txtTimkiemMon.Location = new System.Drawing.Point(100, 3);
            this.txtTimkiemMon.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimkiemMon.Name = "txtTimkiemMon";
            this.txtTimkiemMon.Size = new System.Drawing.Size(155, 20);
            this.txtTimkiemMon.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên món cần tìm";
            // 
            // frmQLMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 373);
            this.Controls.Add(this.dataGV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.txtTimkiemMon);
            this.Controls.Add(this.label1);
            this.Name = "frmQLMon";
            this.Text = "QLMon";
            this.Load += new System.EventHandler(this.frmQLMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGV;
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
        private System.Windows.Forms.Label label1;
    }
}