
namespace COFFEEMANAGER
{
    partial class frmThemMon
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
            this.cbThem_Madm = new System.Windows.Forms.ComboBox();
            this.btnThem_monmoi = new System.Windows.Forms.Button();
            this.txtThem_Gia = new System.Windows.Forms.TextBox();
            this.txtThem_Tenmon = new System.Windows.Forms.TextBox();
            this.txtThem_Mamon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbThem_Madm
            // 
            this.cbThem_Madm.FormattingEnabled = true;
            this.cbThem_Madm.Location = new System.Drawing.Point(81, 113);
            this.cbThem_Madm.Margin = new System.Windows.Forms.Padding(2);
            this.cbThem_Madm.Name = "cbThem_Madm";
            this.cbThem_Madm.Size = new System.Drawing.Size(92, 21);
            this.cbThem_Madm.TabIndex = 13;
            // 
            // btnThem_monmoi
            // 
            this.btnThem_monmoi.Location = new System.Drawing.Point(13, 147);
            this.btnThem_monmoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem_monmoi.Name = "btnThem_monmoi";
            this.btnThem_monmoi.Size = new System.Drawing.Size(158, 19);
            this.btnThem_monmoi.TabIndex = 12;
            this.btnThem_monmoi.Text = "Thêm món mới";
            this.btnThem_monmoi.UseVisualStyleBackColor = true;
            this.btnThem_monmoi.Click += new System.EventHandler(this.btnThem_monmoi_Click);
            // 
            // txtThem_Gia
            // 
            this.txtThem_Gia.Location = new System.Drawing.Point(64, 68);
            this.txtThem_Gia.Margin = new System.Windows.Forms.Padding(2);
            this.txtThem_Gia.Name = "txtThem_Gia";
            this.txtThem_Gia.Size = new System.Drawing.Size(98, 20);
            this.txtThem_Gia.TabIndex = 9;
            // 
            // txtThem_Tenmon
            // 
            this.txtThem_Tenmon.Location = new System.Drawing.Point(64, 40);
            this.txtThem_Tenmon.Margin = new System.Windows.Forms.Padding(2);
            this.txtThem_Tenmon.Name = "txtThem_Tenmon";
            this.txtThem_Tenmon.Size = new System.Drawing.Size(177, 20);
            this.txtThem_Tenmon.TabIndex = 10;
            // 
            // txtThem_Mamon
            // 
            this.txtThem_Mamon.Location = new System.Drawing.Point(64, 6);
            this.txtThem_Mamon.Margin = new System.Windows.Forms.Padding(2);
            this.txtThem_Mamon.Name = "txtThem_Mamon";
            this.txtThem_Mamon.Size = new System.Drawing.Size(143, 20);
            this.txtThem_Mamon.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã danh mục";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gía";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên món";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã món";
            // 
            // frmThemMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 231);
            this.Controls.Add(this.cbThem_Madm);
            this.Controls.Add(this.btnThem_monmoi);
            this.Controls.Add(this.txtThem_Gia);
            this.Controls.Add(this.txtThem_Tenmon);
            this.Controls.Add(this.txtThem_Mamon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmThemMon";
            this.Text = "frmThemMon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbThem_Madm;
        private System.Windows.Forms.Button btnThem_monmoi;
        private System.Windows.Forms.TextBox txtThem_Gia;
        private System.Windows.Forms.TextBox txtThem_Tenmon;
        private System.Windows.Forms.TextBox txtThem_Mamon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}